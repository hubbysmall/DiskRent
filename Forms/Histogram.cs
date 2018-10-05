using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Service;

namespace Forms
{
    public partial class Histogram : UserControl
    {
        private RentDbContext context;

        public Histogram()
        {
            InitializeComponent();
            context = new RentDbContext();
        }

        private const int MIN_VALUE = 0;
        private const int MAX_VALUE = 100;

        private List<GenreGroupViewModel> DataValues;
        private Label[] Labels = new Label[10];


        private List<GenreGroupViewModel> GenreCount()
        {
            return context.Disks.GroupBy(d => d.genre).Select(g => new GenreGroupViewModel { GenreName = g.Key, GenreCount = g.Count() }).ToList();
        }

        private void initialize_data()
        {
            DataValues = GenreCount();

            for (int i = 0; i < DataValues.Count; i++)
            {
                //DataValues[i] = rnd.Next(MIN_VALUE + 5, MAX_VALUE - 5);
            
                Labels[i] = new Label();
                Labels[i].Parent = picHistoPictureBox;
                Labels[i].Text = DataValues[i].GenreName;
                Labels[i].ForeColor = Color.Black;
                Labels[i].BackColor = Color.Transparent;
                Labels[i].AutoSize = true;
            }
        }

        private void DrawHistogram(Graphics gr, Color back_color, List<GenreGroupViewModel> values, int width, int height)
        {
            Color[] Colors = new Color[] {
            Color.Red, Color.LightGreen, Color.Blue,
            Color.Pink, Color.Green, Color.LightBlue,
            Color.Orange, Color.Yellow, Color.Purple
            };

            gr.Clear(back_color);

            // Make a transformation to the PictureBox.
            RectangleF data_bounds =
                new RectangleF(0, 0, values.Count, MAX_VALUE);
            PointF[] points =
            {
            new PointF(0, height),
            new PointF(width, height),
            new PointF(0, 0)
            };
            Matrix transformation = new Matrix(data_bounds, points);
            gr.Transform = transformation;

            // Draw the histogram.
            using (Pen thin_pen = new Pen(Color.Black, 0))
            {
                for (int i = 0; i < values.Count; i++)
                {
                    RectangleF rect = new RectangleF(i, 0, 1, values[i].GenreCount);
                    using (Brush the_brush =
                         new SolidBrush(Colors[i % Colors.Length]))
                    {
                        gr.FillRectangle(the_brush, rect);
                        gr.DrawRectangle(thin_pen, rect.X, rect.Y,
                            rect.Width, rect.Height);
                    }

                    // Position the value's label.
                    PointF[] point =
                    {
                new PointF(rect.Left + rect.Width / 2f, rect.Bottom),
            };
                    transformation.TransformPoints(point);
                    Labels[i].Location = new Point(
                        (int)point[0].X - Labels[i].Width / 2,
                        (int)point[0].Y - Labels[i].Height);
                }
            }

            gr.ResetTransform();
            gr.DrawRectangle(Pens.Black, 0, 0, width - 1, height - 1);
        }

        private void do_statistics_button_Click(object sender, EventArgs e)
        {
            initialize_data();

            picHistoPictureBox.Image = new Bitmap(500, 500);
            Graphics g = Graphics.FromImage(picHistoPictureBox.Image);
            DrawHistogram(g, Color.AntiqueWhite, DataValues,  326,  176);
        }
    }
}
