using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernGUI_V3
{
    public partial class frmTecnicaEstudio : Form
    {
        private const int WorkMinutes = 25;
        private const int RestMinutes = 5;

        private int currentMinutes;
        private int currentSeconds;

        private int iterationCount = 0;

        private bool isWorking = true;
        private bool isPaused = false;

        private readonly SoundPlayer notifySoundPlayer;
        private SoundPlayer soundPlayer = new SoundPlayer();
        private SoundPlayer soundPlayer2 = new SoundPlayer();

        Bitmap bitmap = new Bitmap("C:\\Users\\50376\\source\\repos\\OrgnizadorTareas-ProyectoPED\\NOTES\\star.png"); // Bitmap
        double angle = 0; // Ángulo inicial
        int centerX; // Coordenada X del centro de rotación
        int centerY; // Coordenada Y del centro de rotación
        int radius = 100; // Radio de la órbita
        public frmTecnicaEstudio()
        {
           InitializeComponent();
            timerPomodoro.Interval = 1000; // 1-second
            timerPomodoro.Tick += timerPomodoro_Tick;
            pictureBox2.Image = bitmap; // Mostrar la imagen en el PictureBox
            centerX = pictureBox2.Width / 685; // Calcular el centro X del PictureBox
            centerY = pictureBox2.Height / 480;

            // sound path: PomodoroTimerApp\bin\Debug\net6.0-windows\sound.wav
            string soundFileName = "C:\\Users\\50376\\source\\repos\\OrgnizadorTareas-ProyectoPED\\NOTES\\sound.wav";
            notifySoundPlayer = InitializeSoundPlayer(soundFileName);

            UpdateTimerDisplay();
        }
        private void ShowErrorMessage(string message, string filePath)
        {
            MessageBox.Show($"{message}\n\nExpected path: {filePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private SoundPlayer InitializeSoundPlayer(string soundFileName)
        {
            try
            {
                if (File.Exists(soundFileName))
                {
                    return new SoundPlayer(soundFileName);
                }

                ShowErrorMessage("Sound file not found.", soundFileName);
                return null;
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Error initializing sound player: {ex.Message}", soundFileName);
                return null;
            }
        }
        private void UpdateTimeRemaining()
        {
            if (currentSeconds == 0)
            {
                currentMinutes--;
                currentSeconds = 59;
            }
            else
            {
                currentSeconds--;
            }
        }

        private void PlayNotificationSound()
        {
            if (notifySoundPlayer != null)
            {
                try
                {
                    notifySoundPlayer.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error playing sound: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void StartNewSession()
        {
            currentMinutes = WorkMinutes;
            currentSeconds = 0;
            iterationCount = 0;
            isWorking = true;
            isPaused = false;
            timerPomodoro.Start();
        }

        private void SkipToNextPomodoro()
        {
            iterationCount++;
            isWorking = !isWorking;
            currentMinutes = isWorking ? WorkMinutes : RestMinutes;
            currentSeconds = 0;
        }

        private void UpdateTimerDisplay()
        {
            labelTimer.Text = $"{currentMinutes:D2}:{currentSeconds:D2}";

            textBoxStatus.Text = isWorking ? "Time to Focus!" : "Time for a Break!";
            textBoxIterations.Text = $"Iteration: {iterationCount}";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Asignar la ruta del archivo de sonido al SoundPlayer
            soundPlayer2.SoundLocation = "C:\\Users\\50376\\source\\repos\\OrgnizadorTareas-ProyectoPED\\NOTES\\ready.wav";
            soundPlayer.SoundLocation = "C:\\Users\\50376\\source\\repos\\OrgnizadorTareas-ProyectoPED\\NOTES\\song.wav";

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void timerPomodoro_Tick(object sender, EventArgs e)
        {
            if (currentMinutes == 0 && currentSeconds == 0)
            {
                isWorking = !isWorking;
                iterationCount++;
                currentMinutes = isWorking ? WorkMinutes : RestMinutes;
                currentSeconds = 0;

                PlayNotificationSound();
            }
            else
            {
                if (!isPaused)
                {
                    UpdateTimeRemaining();
                }
            }

            UpdateTimerDisplay();
        }

        private void btnStartPause_Click(object sender, EventArgs e)
        {
            soundPlayer2.Play();
            isPaused = !isPaused;

            if (!timerPomodoro.Enabled)
            {
                StartNewSession();
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            SkipToNextPomodoro();
            PlayNotificationSound();
            UpdateTimerDisplay();
        }

        private void btnEndSession_Click(object sender, EventArgs e)
        {
            // Reproducir el sonido al hacer clic en el botón
            timermov.Start();
            soundPlayer.Play();
            timerPomodoro.Stop();
            currentMinutes = 0;
            currentSeconds = 0;
            iterationCount = 0;
            isWorking = true;
            isPaused = false;
            UpdateTimerDisplay();
            pictureBox2.ImageLocation = "C:\\Users\\50376\\source\\repos\\OrgnizadorTareas-ProyectoPED\\NOTES\\star.jpg";


            // Mover la imagen
        }

        private void timermov_Tick(object sender, EventArgs e)
        {

            int newX = (int)(685 + radius * Math.Cos(angle));
            int newY = (int)(480 + radius * Math.Sin(angle));

            // Establecer la nueva ubicación de la imagen
            pictureBox2.Location = new Point(newX, newY);

            // Actualizar el ángulo para el próximo paso
            angle += 0.05;
        }

        private void btnEndSession_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox2.Visible = true;
        }

      
    }
}
