using System.Collections.Generic;
using System.Drawing;
using MusicSignatureBuilder;
using System.Drawing.Drawing2D;
using System.Linq;

namespace FifthsTrajectoryVisualizer
{

    public class DrawingUtils
    {
        private static string[] letters = {"C", "G", "D", "A", "E", "H", "G♭/F♯", "D♭", "A♭", "E♭", "B", "F"};

        public static void DrawGrid(Graphics g, int cellsCount, float cellSize, Pen pen)
        {
            for (int i = 0; i <= cellsCount; i++)
            {
                g.DrawLine(pen, i * cellSize, 0, i * cellSize, cellsCount * cellSize);
                g.DrawLine(pen, 0, i * cellSize, cellsCount * cellSize, i * cellSize);
            }
        }

        public static void DrawMainAxis(Graphics g, int side, IEnumerable<int> keys)
        {
            var half = side / 2f;
            var center = new PointF(half, half);

            AdjustableArrowCap bigArrow = new AdjustableArrowCap(10, 10);
            Pen pen = new Pen(Color.LimeGreen, 2);
            pen.CustomEndCap = bigArrow;

            for (int i = 0; i < letters.Length; i++)
            {
                if (keys.Contains(i))
                    g.DrawLine(pen, half, side, half, 0);

                g.TranslateTransform(-center.X, -center.Y, MatrixOrder.Append);
                g.RotateTransform(30, MatrixOrder.Append);
                g.TranslateTransform(center.X, center.Y, MatrixOrder.Append);
            }
        }

        public static void PlotData(Graphics g, Dictionary<int, CPMS> points, int side, float length, bool showTrack, bool showPoints)
        {
            float markerSize = 2f;
            var previousPoint = PointF.Empty;
            foreach (var id in points.Keys.OrderBy(k => k))
            {
                var point = Translate(points[id].Coordinates, side, length);

                if(showPoints)
                    g.DrawEllipse(Pens.DarkGreen, point.X - markerSize, point.Y - markerSize, markerSize * 2, markerSize * 2);

                if (!previousPoint.IsEmpty && showTrack)
                    g.DrawLine(Pens.DarkSeaGreen, previousPoint, point);

                previousPoint = point;
            }
        }

        public static void DrawCPMS(Graphics g, int side, float length, CPMS point, bool showComponents)
        {
            float markerSize = 2f;
            var half = side / 2f;
            var center = new PointF(half, half);

            AdjustableArrowCap bigArrow = new AdjustableArrowCap(5, 5);
            Pen pen = new Pen(Color.DeepPink, 2);
            pen.CustomEndCap = bigArrow;

            if (showComponents)
            {
                foreach (var p in point.Components)
                {
                    g.DrawLine(pen, center, Translate(p, side, length));
                }
            }

            var transCPMS = Translate(point.Coordinates, side, length);
            var pointPen = new Pen(Color.Red, 3);
            g.DrawEllipse(pointPen, transCPMS.X - markerSize, transCPMS.Y - markerSize, markerSize * 2, markerSize * 2);
        }

        public static PointF Translate(MusicSignatureBuilder.Point point, int side, float length)
        {
            var center = side / 2f;
            return new PointF(center + (length * point.X), center - (length * point.Y));
        }

        public static void DrawCenterOfTrajectory(Graphics g, MusicSignatureBuilder.Point point, int side, float length)
        {
            float markerSize = 4f;
            var translated = Translate(point, side, length);
            g.FillEllipse(Brushes.DeepSkyBlue, translated.X - markerSize, translated.Y - markerSize, markerSize * 2,
                markerSize * 2);
            g.FillEllipse(Brushes.DarkOrange, translated.X - markerSize / 2, translated.Y - markerSize / 2, markerSize,
                markerSize);
        }

        public static void DrawCircles(Graphics g, int side, float cellSize, float distance)
        {
            float half = side / 2f;

            for (float i = half - cellSize; i > -0.1f; i -= cellSize)
            {
                if (i < .1f) i = 0;
                if ((half - i + .01f) % distance < .5f)
                    g.DrawEllipse(Pens.Black, i, i, 2 * (half - i), 2 * (half - i));
                else
                    g.DrawEllipse(Pens.LightGray, i, i, 2 * (half - i), 2 * (half - i));
            }
        }

        public static void DrawLabels(Graphics g, int side)
        {
            float half = side / 2f;
            var center = new PointF(half, half);
            var font = new Font("Times New Roman", 14);

            for (int i = 0; i < letters.Length; i++)
            {
                if (i == 6)
                    g.DrawString(letters[i], font, Brushes.Black, half - 30, 0);
                else
                    g.DrawString(letters[i], font, Brushes.Black, half - 10, 0);
                g.TranslateTransform(-center.X, -center.Y, MatrixOrder.Append);
                g.RotateTransform(30, MatrixOrder.Append);
                g.TranslateTransform(center.X, center.Y, MatrixOrder.Append);
            }
        }

        public static void DrawNumbers(Graphics g, int side, float distance)
        {
            float half = side / 2f;
            var font = new Font("Arial", 10);
            var brush = Brushes.DarkGray;

            int counter = 1;
            for (float i = half + distance; i <= side; i += distance)
            {
                g.DrawString(counter.ToString(), font, brush, i, half);
                g.DrawString((-counter).ToString(), font, brush, half, i);
                counter++;
            }

            counter = -1;
            for (float i = half - distance; i >= 0; i -= distance)
            {
                g.DrawString(counter.ToString(), font, brush, i, half);
                g.DrawString((-counter).ToString(), font, brush, half, i);
                counter--;
            }
        }

        public static void DrawAxes(Graphics g, int side)
        {
            var half = side / 2;
            var center = new PointF(half, half);
            var pen = new Pen(Color.Black, 1);

            g.DrawLine(pen, half, 0, half, side);
            g.DrawLine(pen, 0, half, side, half);

            g.TranslateTransform(-center.X, -center.Y, MatrixOrder.Append);
            g.RotateTransform(30, MatrixOrder.Append);
            g.TranslateTransform(center.X, center.Y, MatrixOrder.Append);

            g.DrawLine(pen, half, 0, half, side);
            g.DrawLine(pen, 0, half, side, half);

            g.TranslateTransform(-center.X, -center.Y, MatrixOrder.Append);
            g.RotateTransform(30, MatrixOrder.Append);
            g.TranslateTransform(center.X, center.Y, MatrixOrder.Append);

            g.DrawLine(pen, half, 0, half, side);
            g.DrawLine(pen, 0, half, side, half);

            g.TranslateTransform(-center.X, -center.Y, MatrixOrder.Append);
            g.RotateTransform(-60, MatrixOrder.Append);
            g.TranslateTransform(center.X, center.Y, MatrixOrder.Append);
        }
    }
}