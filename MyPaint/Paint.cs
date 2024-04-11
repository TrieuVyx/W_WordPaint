using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class Paint : Form
    {
        private PointF currentPosition;
        private ShapeEntity currentShape;
        private bool isDrawing = false;
        private Point startPosition;
        List<ShapeEntity> shapes = new List<ShapeEntity>();
        private bool isButton1Clicked = false;
        private bool isButton2Clicked = false;
        private ShapeEntity selectedShape;
        private Point originalPosition;
        private bool isDragging;
        public Paint()
        {
            InitializeComponent();
            shapes = new List<ShapeEntity>();
            panelCanvas.MouseDown += panelCanvas_MouseDown;
            panelCanvas.Paint += panelCanvas_Paint;
            panelCanvas.MouseMove += panelCanvas_MouseMove;
            panelCanvas.MouseUp += panelCanvas_MouseUp;
        }


        private void drawing_MouseMove(object sender, MouseEventArgs e)
        {
            currentPosition = PointTo(e.Location);
            label1.Text = string.Format("{0}, {1}", e.Location.X, e.Location.Y);
            label2.Text = string.Format("{0}, {1}", currentPosition.X, currentPosition.Y);

        }

        private PointF PointTo(Point point)
        {
            return new PointF(point.X, point.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isDrawing = true;
            isButton1Clicked = true;
            isButton2Clicked = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            isDrawing = true;
            isButton1Clicked = false;
            isButton2Clicked = true;

        }


        private void panelCanvas_MouseDown(object sender, MouseEventArgs e)

        {

            if (isDrawing)
            {
                startPosition = e.Location;

                if (isButton1Clicked)
                {
                    currentShape = new RectangleShape(startPosition);
                }
                else if (isButton2Clicked)
                {
                    currentShape = new CircleShape(startPosition);
                }
                currentShape.UpdatePosition(startPosition);
            }
            else
            {

                foreach (var shape in shapes)
                {
                    if (shape.Contains(e.Location))
                    {
                        shape.IsSelected = true;
                    }
                    else
                    {
                        shape.IsSelected = false;
                    }
                }

                panelCanvas.Invalidate();
            }


        }

        private void panelCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing && currentShape != null)
            {
                currentShape.UpdateSize(e.Location);
                panelCanvas.Invalidate();

            }

        }

        private void panelCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing && currentShape != null)
            {
                currentShape.UpdateSize(e.Location);
                shapes.Add(currentShape);
                panelCanvas.Invalidate();

                isDrawing = false;
                currentShape = null;

            }
        }

        private void panelCanvas_Paint(object sender, PaintEventArgs e)
        {
            foreach (var shape in shapes)
            {
                shape.Draw(e.Graphics);

                if (shape.IsSelected)
                {
                    shape.Draw(e.Graphics);
                }
            }

            if (currentShape != null)
            {
                currentShape.Draw(e.Graphics);
            }

        }

    }
}

