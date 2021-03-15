using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Among_Us_Radar
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        const string adressPointerPlayers = "GameAssembly.dll+02C69F60,5C,24,7C,";
        const string adressOffsetToAvatarPlayer = ",34,8";
        const string adressOffsetX = ",54";
        const string adressOffsetY = ",58";
        const string adressPlayerLocalisation = "UnityPlayer.dll+012CA8A8,3C,74,C,5C";
        const string adressPlayerLocalisationOffsetX = ",2C";
        const string adressPlayerLocalisationOffsetY = ",30";
        //const string adressPlayerInGame = "GameAssembly.dll+02B26A18,5C,0,54,C";
        public MapSpecification[] mapSpecification = new MapSpecification[] { 
            new MapSpecification(572,170,@"Maps\skeld.png"),
            new MapSpecification(300,540,@"Maps\MiraHQ.png"),
            new MapSpecification(30,0,@"Maps\Polus.png")
        };
        bool drawing = false;
        bool saveClick = false;
        Memory.Mem memory = new Memory.Mem();

        public Form1()
        {
            InitializeComponent();
            comboBoxMap.Items.AddRange(new object[] {"The Skeld",
                        "Mira Hq",
                        "Polus" });
            MemoryOpenProcess();
            graphics = panelRadar.CreateGraphics();       

        }

        public void MemoryOpenProcess()
        {
            try
            {
                memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            }
            catch(Exception)
            {
                //Application.Run(new FormErrorOpenProcess());
            }
            comboBoxMap.SelectedIndex = memory.ReadInt("GameAssembly.dll+02C6C4B8,5C,14,10");
        }


        /// <summary>
        /// Teleport hack 
        /// </summary>
        private void panelRadar_MouseUp(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            float fx = ((float)x - mapSpecification[comboBoxMap.SelectedIndex].X) / 23;
            float fy = ((float)y - mapSpecification[comboBoxMap.SelectedIndex].Y) / 23 * -1;
            memory.WriteMemory(adressPlayerLocalisation + adressPlayerLocalisationOffsetX, "float", fx.ToString());
            memory.WriteMemory(adressPlayerLocalisation + adressPlayerLocalisationOffsetY, "float", fy.ToString());
        }
        /// <summary>
        /// Radar
        /// </summary>
        private async void ButtonStart_Click(object sender, EventArgs e)
        {
            ButtonStart.Enabled = false;
            drawing = true;
            PointF PlayerPoint;
            Image image = mapSpecification[comboBoxMap.SelectedIndex].ImageLoad();
            int mapShiftX = mapSpecification[comboBoxMap.SelectedIndex].X;
            int mapShiftY = mapSpecification[comboBoxMap.SelectedIndex].Y;
            Dictionary<int, PlayersSpecificationRadar> adressoffsetPlayers = new Dictionary<int, PlayersSpecificationRadar>();
            adressoffsetPlayers.Add(0, new PlayersSpecificationRadar { AdressOffset = "5C", Pen = new Pen(Color.Red, 7) });
            adressoffsetPlayers.Add(1, new PlayersSpecificationRadar { AdressOffset = "8C", Pen = new Pen(Color.Green, 7) });
            adressoffsetPlayers.Add(2, new PlayersSpecificationRadar { AdressOffset = "BC", Pen = new Pen(Color.White, 7) });
            adressoffsetPlayers.Add(3, new PlayersSpecificationRadar { AdressOffset = "EC", Pen = new Pen(Color.Yellow, 7) });
            adressoffsetPlayers.Add(4, new PlayersSpecificationRadar { AdressOffset = "11C", Pen = new Pen(Color.Cyan, 7) });
            adressoffsetPlayers.Add(5, new PlayersSpecificationRadar { AdressOffset = "14C", Pen = new Pen(Color.DarkBlue, 7) });
            adressoffsetPlayers.Add(6, new PlayersSpecificationRadar { AdressOffset = "17C", Pen = new Pen(Color.Black, 7) });
            adressoffsetPlayers.Add(7, new PlayersSpecificationRadar { AdressOffset = "1AC", Pen = new Pen(Color.DeepPink, 7) });
            adressoffsetPlayers.Add(8, new PlayersSpecificationRadar { AdressOffset = "1DC", Pen = new Pen(Color.SkyBlue, 7) });
            adressoffsetPlayers.Add(9, new PlayersSpecificationRadar { AdressOffset = "20C", Pen = new Pen(Color.Orange, 7) });     
            AddAdressOffsetPlayerInNumeric(adressoffsetPlayers);     

            await Task.Run(() =>
            {
                while (drawing)
                {
                    graphics.DrawImage(image, new Rectangle(0, 0, 1024, 620), new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);
                    //if (CheckPlayers.Checked)
                    //{
                    //    NumericPlayers.Value = (decimal)memory.ReadInt(adressPlayerInGame);
                    //}
                    for (int i = 0; i <= (NumericPlayers.Value-1); i++)
                    {
                        PlayerPoint = ReadLocalization(adressoffsetPlayers[i].AdressOffset);
                        PlayerPoint.Y *= 23 * -1;
                        PlayerPoint.X *= 23;
                        graphics.DrawRectangle(adressoffsetPlayers[i].Pen, PlayerPoint.X + mapShiftX, PlayerPoint.Y + mapShiftY, 2F, 2F);
                    }
                    Thread.Sleep(20);
                    
                    if (saveClick)
                    {
                        NumericAdressHexAddToAdressOffsetPlayers(adressoffsetPlayers);
                        saveClick = false;
                        AddAdressOffsetPlayerInNumeric(adressoffsetPlayers);
                        mapShiftX = (int)numericSizeX.Value;
                        mapShiftY = (int)numericSizeY.Value;
                    }
                }
            });
            ButtonStart.Enabled = true;

        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            drawing = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveClick = true;
        }

        private PointF ReadLocalization(string PlayerOffset)
        {
            return new PointF(memory.ReadFloat(adressPointerPlayers + PlayerOffset + adressOffsetToAvatarPlayer + adressOffsetX), memory.ReadFloat(adressPointerPlayers + PlayerOffset + adressOffsetToAvatarPlayer + adressOffsetY));
        }

        private void NumericAdressHexAddToAdressOffsetPlayers(Dictionary<int, PlayersSpecificationRadar> adressoffsetPlayers)
        {
            foreach (Control gb in this.Controls)
            {
                if (gb is GroupBox)
                {
                    int j = 9;
                    foreach (Control tb in gb.Controls)
                    {
                        if (tb is NumericUpDown)
                        {
                            adressoffsetPlayers[j].AdressOffset = tb.Text;
                            j--;
                        }
                    }
                }
            }

        }

        private void AddAdressOffsetPlayerInNumeric(Dictionary<int, PlayersSpecificationRadar> adressoffsetPlayers)
        {
            foreach (Control gb in this.Controls)
            {
                if (gb is GroupBox)
                {
                    int j = 9;
                    foreach (Control tb in gb.Controls)
                    {
                        if (tb is NumericUpDown)
                        {
                            tb.Text = adressoffsetPlayers[j].AdressOffset;
                            j--;
                        }
                    }
                }
            }
        }

        public Image ImageLoad(string path)
        {
            string pathRecalculate = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), path);
            Image image = Image.FromFile(pathRecalculate);
            return image;
        }

        private void ComboBoxMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            memory.WriteMemory("GameAssembly.dll+02C6C4B8,5C,14,10", "int", comboBoxMap.SelectedIndex.ToString());
        }

        private void ButtonSaveAll_Click(object sender, EventArgs e)
        {
            saveClick = true;
        }
    }
}
