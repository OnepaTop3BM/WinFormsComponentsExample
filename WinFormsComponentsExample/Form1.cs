using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Newtonsoft.Json;

namespace WinFormsComponentsExample
{
    public partial class Form1 : Form
    {
        List<ChartPicture> BasePictures = new List<ChartPicture>();
        List<ChartPicture> chartPictures = new List<ChartPicture>();

        private bool selected = false;
        private bool moving = false;

        private ChartPicture selectedPicture;

        private enum CanResizeMode {crmNone, crmLeftTop, crmLeftBottom, crmRightTop, crmRightBottom};

        private CanResizeMode canResizeMode = CanResizeMode.crmNone;

        private int x0;
        private int y0;

        private int chX0;
        private int chY0;
        private int chW;
        private int chH;

        private int _currentX, _currentY;

        private int CurrentX
        {
            get { return _currentX; }
            set
            {
                _currentX = value;
            }
        }

        private int CurrentY
        {
            get { return _currentY; }
            set
            {
                _currentY = value;
            }
        }

        private int _currentWidth, _currentHeight;

        private int CurrentWidth
        {
            get { return _currentWidth; }
            set
            {
                _currentWidth = value;
            }
        }

        private int CurrentHeight
        {
            get { return _currentHeight; }
            set
            {
                _currentHeight = value;
            }
        }

        //для лога
        private void UpdateLogBox(int x, int y)
        {
            logBox.Text = String.Format("{0},{1}", x, y);
        }

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Application.ExecutablePath;

            InitBasePictures();
        }

        private void InitBasePictures()
        {
            BasePictures = new List<ChartPicture>();

            string filename = String.Format("{0}", Application.ExecutablePath);

            ChartPicture FormulaA = new ChartPicture(50, 50) { Formula = "y=x^2", Image = imageList1.Images[0] };
            BasePictures.Add(FormulaA);

            ChartPicture FormulaB = new ChartPicture(50, 50) { Formula = "SIN(x)", Image = imageList1.Images[1] };
            BasePictures.Add(FormulaB);

            ChartPicture FormulaC = new ChartPicture(50, 50) { Formula = "sqrt(x)", Image = imageList1.Images[2] };
            BasePictures.Add(FormulaC);

            listViewBaseComponents.LargeImageList = imageList1;

            ListViewItem item = new ListViewItem("formula A", 0);
            listViewBaseComponents.Items.Add(item);

            item = new ListViewItem("formula_B", 1);
            listViewBaseComponents.Items.Add(item);

            item = new ListViewItem("sqrt(x)", 2);
            listViewBaseComponents.Items.Add(item);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            chartPictures.Clear();
            listViewProjectComponents.Items.Clear();
            panelWorkArea.Controls.Clear();
            selectedPicture = null;
        }

        private void ChOnMouseMove(object sender, MouseEventArgs mouseEventArgs)
        {
            moving = true;

            if (selected)
            {
                EraseOldSelection();
                if (canResizeMode == CanResizeMode.crmNone)
                {
                    CurrentX = chX0 + mouseEventArgs.X - x0;
                    CurrentY = chY0 + mouseEventArgs.Y - y0;

                    if (selectedPicture != null)
                    {
                        CurrentWidth = selectedPicture.Width;
                        CurrentHeight = selectedPicture.Height;
                    }

                    this.Cursor = Cursors.SizeAll;
                }
                else if (canResizeMode == CanResizeMode.crmLeftTop)
                {
                    CurrentX = chX0 + mouseEventArgs.X - x0;
                    CurrentY = chY0 + mouseEventArgs.Y - y0;

                    CurrentWidth = chW - mouseEventArgs.X - x0;
                    CurrentHeight = chH - mouseEventArgs.Y - y0;
                }
                else if (canResizeMode == CanResizeMode.crmRightBottom)
                {
                    CurrentX = chX0;
                    CurrentY = chY0;

                    CurrentWidth = chW + mouseEventArgs.X - x0;
                    CurrentHeight = chH + mouseEventArgs.Y - y0;
                }
                else if (canResizeMode == CanResizeMode.crmRightTop)
                {
                    CurrentX = chX0;
                    CurrentY = chY0 + mouseEventArgs.Y - y0;

                    CurrentWidth = chW + mouseEventArgs.X - x0;
                    CurrentHeight = chH - mouseEventArgs.Y - y0;
                }
                else if (canResizeMode == CanResizeMode.crmLeftBottom)
                {
                    CurrentX = chX0 + mouseEventArgs.X - x0;
                    CurrentY = chY0;

                    CurrentWidth = chW - mouseEventArgs.X - x0;
                    CurrentHeight = chH + mouseEventArgs.Y - y0;
                }

                DrawSelectionRegion();
            }
            else
            {
                if (mouseEventArgs.X < 10 && mouseEventArgs.Y < 10)
                {
                    canResizeMode = CanResizeMode.crmLeftTop;
                    this.Cursor = Cursors.SizeNWSE;
                }
                else if (selectedPicture != null && mouseEventArgs.X > selectedPicture.Width - 10 && mouseEventArgs.Y > selectedPicture.Height - 10)
                {
                    canResizeMode = CanResizeMode.crmRightBottom;
                    this.Cursor = Cursors.SizeNWSE;
                }
                else if (selectedPicture != null && mouseEventArgs.X > selectedPicture.Width - 10 && mouseEventArgs.Y < 10)
                {
                    canResizeMode = CanResizeMode.crmRightTop;
                    this.Cursor = Cursors.SizeNESW;
                }
                else if (selectedPicture != null && mouseEventArgs.X < 10 && mouseEventArgs.Y > selectedPicture.Height - 10)
                {
                    canResizeMode = CanResizeMode.crmLeftBottom;
                    this.Cursor = Cursors.SizeNESW;
                }
                else
                {
                    canResizeMode = CanResizeMode.crmNone;
                    this.Cursor = DefaultCursor;
                }
            }
        }

        private void ChOnMouseDown(object sender, MouseEventArgs mouseEventArgs)
        {
            moving = false;

            EraseOldSelection();

            x0 = mouseEventArgs.X;
            y0 = mouseEventArgs.Y;

            chX0 = ((ChartPicture)sender).X;
            chY0 = ((ChartPicture)sender).Y;
            chW = ((ChartPicture)sender).Width;
            chH = ((ChartPicture)sender).Height;

            selected = true;
            selectedPicture = (ChartPicture)sender;

            DrawSelectionRegion();

            UpdateProperties(selectedPicture);
        }

        private void ChOnMouseUp(object sender, MouseEventArgs mouseEventArgs)
        {
            selected = false;

            EraseOldSelection();

            if (selectedPicture != null)
            {
                if (moving)
                {
                    selectedPicture.X = CurrentX;
                    selectedPicture.Y = CurrentY;

                    selectedPicture.Width = CurrentWidth;
                    selectedPicture.Height = CurrentHeight;
                }

                CurrentX = selectedPicture.X;
                CurrentY = selectedPicture.Y;

                CurrentWidth = selectedPicture.Width;
                CurrentHeight = selectedPicture.Height;

                if(String.IsNullOrEmpty(selectedPicture.ImagePath))
                    selectedPicture.Update();

                DrawSelectionRegion();
            }
        }

        void UpdateProperties(ChartPicture chartPicture)
        {
            valueX.Value = chartPicture.X;
            valueY.Value = chartPicture.Y;
            valueWidth.Value = chartPicture.Width;
            valueHeight.Value = chartPicture.Height;
            formulaBox.Text = chartPicture.Formula;
            cbEnabled.Checked = chartPicture.Enabled;
            cbVisible.Checked = chartPicture.Visible;

            if (chartPicture.Image == null && !String.IsNullOrEmpty(chartPicture.ImagePath))
                chartPicture.Image = Image.FromFile(chartPicture.ImagePath);

            pictureBoxPreview.Image = chartPicture.Image;
        }

        private void formulaBox_TextChanged(object sender, EventArgs e)
        {
            if (selectedPicture != null)
                selectedPicture.Formula = formulaBox.Text;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            selectedPicture = null;

            valueX.Value = 0;
            valueY.Value = 0;
            formulaBox.Text = "";
        }

        private void panelWorkArea_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("System.Windows.Forms.ListView+SelectedListViewItemCollection", false))
            {
                Point pt = ((Panel)sender).PointToClient(new Point(e.X, e.Y));

                EraseOldSelection();

                ChartPicture pic = new ChartPicture(150, 150);
                pic.X = pt.X;
                pic.Y = pt.Y;
                CurrentX = pt.X;
                CurrentY = pt.Y;

                ListView.SelectedListViewItemCollection lvi =
                    (ListView.SelectedListViewItemCollection)
                        e.Data.GetData("System.Windows.Forms.ListView+SelectedListViewItemCollection");
                if (lvi != null)
                {
                    pic.Formula = lvi[0].Text;
                }

                chartPictures.Add(pic);

                AddNewObject(pic);

                selectedPicture = pic;

                if (selectedPicture != null)
                {
                    CurrentX = selectedPicture.X;
                    CurrentY = selectedPicture.Y;
                    CurrentWidth = selectedPicture.Width;
                    CurrentHeight = selectedPicture.Height;

                    DrawSelectionRegion();
                }

                UpdateProperties(selectedPicture);
            }
        }

        private void AddNewObject(ChartPicture chartObject)
        {
            panelWorkArea.Controls.Add(chartObject);

            listViewProjectComponents.Items.Add(chartObject.Formula);

            chartObject.ContextMenuStrip = contextMenuStrip1;

            chartObject.MouseDown += ChOnMouseDown;
            chartObject.MouseUp += ChOnMouseUp;
            chartObject.MouseMove += ChOnMouseMove;
        }

        private void listViewBaseComponents_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewBaseComponents.DoDragDrop(listViewBaseComponents.SelectedItems, DragDropEffects.Copy);
        }

        private void panelWorkArea_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void valueX_ValueChanged(object sender, EventArgs e)
        {
            EraseOldSelection();
            if (selectedPicture != null)
                selectedPicture.X = (int)valueX.Value;
            //DrawSelectionRegion();
        }

        private void valueY_ValueChanged(object sender, EventArgs e)
        {
            EraseOldSelection();
            if (selectedPicture != null)
                selectedPicture.Y = (int)valueY.Value;
            //DrawSelectionRegion();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedPicture.MouseDown -= ChOnMouseDown;

            chartPictures.Remove(selectedPicture);

            panelWorkArea.Controls.Remove(selectedPicture);

            EraseOldSelection();

            selectedPicture = null;

            UpdateProjectObjectsList();
        }

        private void DrawSelectionItems(Graphics g, Pen pen)
        {
            if (selectedPicture != null)
            {
                selectedPicture.MouseLeave += SelectedPictureOnMouseLeave;

                g.DrawRectangle(pen, new Rectangle(CurrentX - 4, CurrentY - 4, 8, 8));
                g.DrawRectangle(pen, new Rectangle(CurrentX - 4, CurrentY + CurrentHeight - 4, 8, 8));
                g.DrawRectangle(pen, new Rectangle(CurrentX + CurrentWidth - 4, CurrentY - 4, 8, 8));
                g.DrawRectangle(pen, new Rectangle(CurrentX + CurrentWidth - 4, CurrentY + CurrentHeight - 4, 8, 8));
            }
        }

        private void SelectedPictureOnMouseLeave(object sender, EventArgs eventArgs)
        {
            this.Cursor = DefaultCursor;
        }

        //отрисовываем выделение выбранного объекта
        private void DrawSelectionRegion()
        {
            if (selectedPicture != null)
                using (Graphics g = panelWorkArea.CreateGraphics())
                {
                    Rectangle rect = new Rectangle(CurrentX, CurrentY, CurrentWidth - 1, CurrentHeight - 1);
                    Pen pen = new Pen(new SolidBrush(Color.Blue), 1);
                    g.DrawRectangle(pen, rect);
                    Pen pen2 = new Pen(new SolidBrush(Color.Red), 1);
                    DrawSelectionItems(g, pen2);
                }
        }

        //удаляем предыдущее выделение
        private void EraseOldSelection()
        {
            using (Graphics g = panelWorkArea.CreateGraphics())
            {
                Pen pen = new Pen(this.BackColor, 2F);
                DrawSelectionItems(g, pen);
                if (selectedPicture != null)
                {
                    Rectangle oldrect = new Rectangle(CurrentX, CurrentY, CurrentWidth - 1, CurrentHeight - 1);
                    g.DrawRectangle(pen, oldrect);
                }
            }
        }

        private void UpdateProjectObjectsList()
        {
            listViewProjectComponents.Clear();

            foreach (var chartPicture in chartPictures)
            {
                if (chartPicture.Image == null)
                    if (!String.IsNullOrEmpty(chartPicture.ImagePath))
                        chartPicture.Image = Image.FromFile(chartPicture.ImagePath);
                chartPicture.SizeMode = PictureBoxSizeMode.StretchImage;

                AddNewObject(chartPicture);
            }
        }

        //читаем объекты из файла в json
        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            //openFileDialog1.FileName = "*.json";
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (var r = new StreamReader(openFileDialog1.FileName))
                    {
                        String json = r.ReadToEnd();
                        chartPictures = JsonConvert.DeserializeObject<List<ChartPicture>>(json);
                    }

                    //загружаем изображения из той же папки, где был сохранён сам json
                    foreach (var chartPicture in chartPictures)
                    {
                        String imageFilename = String.Format("{0}\\{1}", Path.GetDirectoryName(openFileDialog1.FileName),
                            chartPicture.ImagePath);
                        if (File.Exists(imageFilename))
                            chartPicture.Image = Image.FromFile(imageFilename);
                    }

                    panelWorkArea.Controls.Clear();

                    UpdateProjectObjectsList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении объектов", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //Сохраняем объекты в json
        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            //saveFileDialog1.FileName = "*.json";
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    string json = JsonConvert.SerializeObject(chartPictures);
                    using (var w = new StreamWriter(saveFileDialog1.FileName, false))
                    {
                        w.WriteLine(json);
                    }

                    foreach (var chartPicture in chartPictures)
                    {
                        String imageFilename = String.Format("{0}\\{1}", Path.GetDirectoryName(saveFileDialog1.FileName),
                            chartPicture.ImagePath);
                        if (chartPicture.Image != null && !String.IsNullOrEmpty(chartPicture.ImagePath))
                            if (!File.Exists(imageFilename))
                                chartPicture.Image.Save(imageFilename);
                    }
                    MessageBox.Show("Файл успешно сохранён!", "Сохранение файла");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении объектов", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxPreview_Click(object sender, EventArgs e)
        {
            if (selectedPicture != null)
            {
                //openFileDialog1.FileName = "*.jpg|*.png|*.bmp";
                try
                {
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {

                        pictureBoxPreview.Image = Image.FromFile(openFileDialog1.FileName);
                        selectedPicture.Image = pictureBoxPreview.Image;
                        selectedPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                        selectedPicture.ImagePath = Path.GetFileName(openFileDialog1.FileName);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при загрузке изображения", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void valueHeight_ValueChanged(object sender, EventArgs e)
        {
            EraseOldSelection();
            if (selectedPicture != null)
                selectedPicture.Height = (int)valueHeight.Value;
            DrawSelectionRegion();
        }

        private void valueWidth_ValueChanged(object sender, EventArgs e)
        {
            EraseOldSelection();
            if (selectedPicture != null)
                selectedPicture.Width = (int)valueWidth.Value;
            DrawSelectionRegion();
        }

        private void cbEnabled_Click_1(object sender, EventArgs e)
        {
            if (selectedPicture != null)
                selectedPicture.Enabled = cbEnabled.Checked;
        }

        private void cbVisible_Click(object sender, EventArgs e)
        {
            if (selectedPicture != null)
                selectedPicture.Visible = cbVisible.Checked;
        }

    }
}
