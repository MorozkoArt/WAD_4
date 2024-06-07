using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using WpfControlLibrary1;
using WpfControlLibrary2;
using static System.Windows.Forms.AxHost;
using static WpfControlLibrary1.UserControl1;
using Color = System.Drawing.Color;
using TabControl = System.Windows.Forms.TabControl;
using UserControl1 = WpfControlLibrary1.UserControl1;


namespace WindowsFormsApp7
{
    public partial class I_SHOJU_S_UMA : Form
    {
        UserControl1 wpf = new UserControl1();
        UserControl2 wpf2 = new UserControl2();
        public Vector3D RRR = new Vector3D();
        public double distance;
        public Vector3D RRR2 = new Vector3D();
        public double distance2;
        public I_SHOJU_S_UMA()
        {
            InitializeComponent();
            wpf = (UserControl1)elementHost1.Child;
            wpf2 = (UserControl2)elementHost3.Child;
            wpf.MouseDown += Wpf_MouseDown;
            wpf.MouseMove += Wpf_MouseMove;
            wpf2.MouseDown += Wpf2_MouseDown;
            //wpf.MouseWheel += Wpf_MouseWheel;
            TabControl dynamicTabControl = new TabControl();
            dynamicTabControl.Name = "DynamicTabControl";
            dynamicTabControl.BackColor = Color.White;
            dynamicTabControl.ForeColor = Color.Black;
            dynamicTabControl.Font = new Font("Georgia", 16);    
            dynamicTabControl.Dock = DockStyle.Fill;
            dynamicTabControl.Selected += DynamicTabControl_Selected;
            dynamicTabControl.Deselected += DynamicTabControl_Deselected;
            Controls.Add(dynamicTabControl);
            TabPage tabPage1 = new TabPage();
            tabPage1.Text = "Figure 1";
            tabPage1.Font = new Font("Verdana", 12);
            tabPage1.Controls.Add(elementHost1);
            dynamicTabControl.TabPages.Add(tabPage1);
            TabPage tabPage2 = new TabPage();
            tabPage2.Text = "Figure 2";
            tabPage2.Font = new Font("Verdana", 12);
            dynamicTabControl.TabPages.Add(tabPage2);
            TabPage tabPage3 = new TabPage();
            tabPage3.Text = "Figure 3";
            tabPage3.Font = new Font("Verdana", 12);
            dynamicTabControl.TabPages.Add(tabPage3);
            TabPage tabPage4 = new TabPage();
            tabPage4.Text = "Figure 4";
            tabPage4.Font = new Font("Verdana", 12);
            dynamicTabControl.TabPages.Add(tabPage4);
            TabPage tabPage5 = new TabPage();
            tabPage5.Text = "Figure 5";
            tabPage5.Font = new Font("Verdana", 12);
            dynamicTabControl.TabPages.Add(tabPage5);
            RRR = new Vector3D(wpf.myPCamera.Position.X, wpf.myPCamera.Position.Y, wpf.myPCamera.Position.Z);
            distance = RRR.Length;
            RRR2 = new Vector3D(wpf2.myPCamera.Position.X, wpf2.myPCamera.Position.Y, wpf2.myPCamera.Position.Z);
            distance2 = RRR2.Length;
        }
        

        private void Wpf2_MouseDown(object sender, MouseButtonEventArgs e)
        {           
            wpf2.Point = e.GetPosition(wpf2);
            RayMeshGeometry3DHitTestResult hitResult = VisualTreeHelper.HitTest(wpf2.myViewport3D, wpf2.Point) as RayMeshGeometry3DHitTestResult;
            if (hitResult != null)
            {
                if (hitResult.MeshHit == wpf2.mesh1_1 || hitResult.MeshHit == wpf2.meshX_1 || hitResult.MeshHit == wpf2.mesh_Dekor1)
                {
                    wpf2.myPCamera.Position = new Point3D(-distance2, 0, 0);
                    wpf2.myPCamera.LookDirection = new Vector3D(distance2, 0, 0);
                    wpf.myPCamera.Position = new Point3D(-distance, 0, 0);
                    wpf.myPCamera.LookDirection = new Vector3D(distance, 0, 0);
                    wpf2.updateColorGr(wpf2.model1_1);
                    label1.Text = "Вид Слева";
                }
                else if (hitResult.MeshHit == wpf2.mesh1_2 || hitResult.MeshHit == wpf2.meshY_1 || hitResult.MeshHit == wpf2.mesh_Dekor4)
                {
                    wpf2.myPCamera.Position = new Point3D(0, 0, -distance2);
                    wpf2.myPCamera.LookDirection = new Vector3D(0, 0, distance2);
                    wpf.myPCamera.Position = new Point3D(0, 0, -distance);
                    wpf.myPCamera.LookDirection = new Vector3D(0, 0, distance);
                    wpf2.updateColorGr(wpf2.model1_2);
                    label1.Text = "Вид Сзади";
                }
                else if (hitResult.MeshHit == wpf2.mesh1_3 || hitResult.MeshHit == wpf2.meshX_2 || hitResult.MeshHit == wpf2.mesh_Dekor2)
                {
                    wpf2.myPCamera.Position = new Point3D(distance2, 0, 0);
                    wpf2.myPCamera.LookDirection = new Vector3D(-distance2, 0, 0);
                    wpf.myPCamera.Position = new Point3D(distance, 0, 0);
                    wpf.myPCamera.LookDirection = new Vector3D(-distance, 0, 0);
                    wpf2.updateColorGr(wpf2.model1_3);
                    label1.Text = "Вид Справа";
                }
                else if (hitResult.MeshHit == wpf2.mesh1_4 || hitResult.MeshHit == wpf2.meshY_2 || hitResult.MeshHit == wpf2.mesh_Dekor3)
                {
                    wpf2.myPCamera.Position = new Point3D(0, 0, distance2);
                    wpf2.myPCamera.LookDirection = new Vector3D(0, 0, -distance2);
                    wpf.myPCamera.Position = new Point3D(0, 0, distance);
                    wpf.myPCamera.LookDirection = new Vector3D(0, 0, -distance);
                    wpf2.updateColorGr(wpf2.model1_4);
                    label1.Text = "Вид Спереди";
                }
                else if (hitResult.MeshHit == wpf2.mesh1_5 || hitResult.MeshHit == wpf2.meshZ_2 || hitResult.MeshHit == wpf2.mesh_Dekor5)
                {
                    wpf2.myPCamera.Position = new Point3D(0, distance2, 0.0000001);
                    wpf2.myPCamera.LookDirection = new Vector3D(0, -distance2, -0.0000001);
                    wpf.myPCamera.Position = new Point3D(0, distance, 0.0000001);
                    wpf.myPCamera.LookDirection = new Vector3D(0, -distance, -0.0000001);
                    wpf2.updateColorGr(wpf2.model1_5);
                    label1.Text = "Вид Сверху";
                }
                else if (hitResult.MeshHit == wpf2.mesh1_6 || hitResult.MeshHit == wpf2.meshZ_1 || hitResult.MeshHit == wpf2.mesh_Dekor6)
                {
                    wpf2.myPCamera.Position = new Point3D(0, -distance2, 0.0000001);
                    wpf2.myPCamera.LookDirection = new Vector3D(0, distance2, -0.0000001);
                    wpf.myPCamera.Position = new Point3D(0, -distance, 0.0000001);
                    wpf.myPCamera.LookDirection = new Vector3D(0, distance, -0.0000001);
                    wpf2.updateColorGr(wpf2.model1_6);
                    label1.Text = "Вид Снизу";
                }
            }
        }      
        private void Wpf_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                wpf.point = e.GetPosition(wpf);
            }
        }
        private void Wpf_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                wpf2.OrigninalColorGr();
                label1.Text = "";
                wpf.point2 = e.GetPosition(wpf);
                double deltaX = wpf.point2.X - wpf.point.X;
                double deltaY = wpf.point2.Y - wpf.point.Y;
                double rotationSpeed = 0.3;
                double yawAngle = deltaX * rotationSpeed;
                double pitchAngle = deltaY * rotationSpeed;
                RotateCamera(yawAngle, pitchAngle, wpf.myPCamera.Position.X, wpf.myPCamera.Position.Y, wpf.myPCamera.Position.Z, distance);
                RotateCamera(yawAngle, pitchAngle, wpf2.myPCamera.Position.X, wpf2.myPCamera.Position.Y, wpf2.myPCamera.Position.Z, distance2);
                wpf.point = wpf.point2;

            }
        }
        private void RotateCamera(double yawAngle, double pitchAngle, double X, double Y, double Z, double dis)
        {
            double currentYaw = Math.Atan2(Z, X);
            double currentPitch = Math.Asin(Y / dis);
            double newYaw = currentYaw + ToRadians(yawAngle);
            double newPitch = currentPitch + ToRadians(pitchAngle);
            newPitch = Math.Max(-Math.PI / 2, Math.Min(Math.PI / 2, newPitch));
            double x = dis * Math.Cos(newYaw) * Math.Cos(newPitch);
            double y = dis * Math.Sin(newPitch);
            double z = dis * Math.Sin(newYaw) * Math.Cos(newPitch);
            if (dis == distance2)
            {
                wpf2.myPCamera.Position = new Point3D(x, y, z);
                wpf2.myPCamera.LookDirection = new Vector3D(-x, -y, -z);
            }
            else if (dis == distance)
            {
                wpf.myPCamera.Position = new Point3D(x, y, z);
                wpf.myPCamera.LookDirection = new Vector3D(-x, -y, -z);
            }
        }
        public static double ToRadians(double degrees)
        {
            return degrees * (Math.PI / 180);
        }
        private void DynamicTabControl_Deselected(object sender, TabControlEventArgs e)
        {
            e.TabPage.Controls.Remove(elementHost1);
        }
        private void DynamicTabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 0)
            {
                wpf.index = 0;
                e.TabPage.Controls.Add(elementHost1);
            }
            else if (e.TabPageIndex == 1)
            {
                wpf.index = 1;
                e.TabPage.Controls.Add(elementHost1);
            }
            else if (e.TabPageIndex == 2)
            {
                wpf.index = 2;
                e.TabPage.Controls.Add(elementHost1);
            }
            else if (e.TabPageIndex == 3)
            {
                wpf.index = 3;
                e.TabPage.Controls.Add(elementHost1);
            }
            else if (e.TabPageIndex == 4)
            {
                wpf.index = 4;
                e.TabPage.Controls.Add(elementHost1);
            }
            wpf.update();
            wpf2.update();
            wpf2.OrigninalColorGr();
            label1.Text = "";
        }

        private void I_SHOJU_S_UMA_Load(object sender, EventArgs e)
        {

        }
    }
}
