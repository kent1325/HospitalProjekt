using Hospital.PatientMeasurement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hospital.PatientMeasurement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Patients> patients;

            using (HospitalDatabase db = new HospitalDatabase())
            {
                patients = db.Patients.ToList();
            }


            patient_dataGrid.ItemsSource = patients;
        }

        private void patientAdd_Btn_Click(object sender, RoutedEventArgs e)
        {
            using (HospitalDatabase db = new HospitalDatabase())
            {
                Patients patient = new Patients();
                patient.PatientID = Guid.NewGuid();
                patient.PatientName = "Test Person";
                patient.PatientEmail = "test@test.com";
                patient.PatientCPR = "012345-678";
                patient.PatientAddress = "Adresse 1";
                patient.PatientPostalCode = 1234;

                db.Patients.Add(patient);
                db.SaveChanges();
                UpdateDatagrid();
            }
        }

        private void patientDelete_menuItem_Click(object sender, RoutedEventArgs e)
        {
            using (HospitalDatabase db = new HospitalDatabase())
            {
                try
                {
                    Patients test = patient_dataGrid.SelectedItem as Patients;
                    List<Patients> patient;
                    patient = db.Patients.Where(p => p.PatientID == test.PatientID).ToList();
                    db.Patients.Remove(patient.FirstOrDefault());
                    db.SaveChanges();
                    UpdateDatagrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UpdateDatagrid()
        {
            patient_dataGrid.ItemsSource = null;
            using (HospitalDatabase db = new HospitalDatabase())
            {
                patient_dataGrid.ItemsSource = db.Patients.ToList();
            }
        }

        private void patientEdit_menuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Du vil redigere noget!");
        }
    }
}
