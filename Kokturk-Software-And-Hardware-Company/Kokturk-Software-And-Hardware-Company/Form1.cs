using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kokturk_Software_And_Hardware_Company
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Kokturk_SoftwareEntities kokturk_SoftwareEntities = new Kokturk_SoftwareEntities();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAvailableSoftwareLanguagesShow_Click(object sender, EventArgs e)
        {
            if (comboBoxUsedDeviceSelect.SelectedItem.ToString() == "Cep Telefonu" && comboBoxAppUsageIntended.SelectedItem.ToString() == "Bankacılık")
            {
                var values = kokturk_SoftwareEntities.Programming_Languages.Where(MobileDevice => MobileDevice.Device_Select == 1);
                dataGridViewAvailableSoftwareLanguages.DataSource = values.ToList();
            }
            else if(comboBoxUsedDeviceSelect.SelectedItem.ToString() == "Bilgisayar" && comboBoxAppUsageIntended.SelectedItem.ToString() == "Bankacılık")
            {
                var values = kokturk_SoftwareEntities.Programming_Languages.Where(ComputerDevice => ComputerDevice.Device_Select == 2);
                dataGridViewAvailableSoftwareLanguages.DataSource = values.ToList();
            }
        }

        private void ButtonLanguagesList_Click(object sender, EventArgs e)
        {
            if (radioButtonOnlyMobileProgrammingLanguages.Checked == true)
            {
                var values = kokturk_SoftwareEntities.Programming_Languages.Where(MobileDevice => MobileDevice.Device_Select == 1);
                dataGridViewAvailableSoftwareLanguages.DataSource = values.ToList();
            }
            
            if (radioButtonOnlyDesktopProgrammingLanguages.Checked == true)
            {
                var values = kokturk_SoftwareEntities.Programming_Languages.Where(MobileDevice => MobileDevice.Device_Select == 2);
                dataGridViewAvailableSoftwareLanguages.DataSource = values.ToList();
            }
            
            if (radioButtonMobileAndComputerProgrammingLanguages.Checked == true)
            {
                List<Programming_Languages> listMobileAndComputerProgrammingLanguages = kokturk_SoftwareEntities.Programming_Languages.OrderBy(MobileAndComputer => MobileAndComputer.Device_Select).ToList();
                dataGridViewAvailableSoftwareLanguages.DataSource = listMobileAndComputerProgrammingLanguages;
            }
            
            if (radioButtonComputerFrontEndLanguages.Checked == true)
            {
                var values = kokturk_SoftwareEntities.Programming_Languages.Where(FrontEndLanguages => FrontEndLanguages.Device_Select == 2);
                dataGridViewAvailableSoftwareLanguages.DataSource = values.ToList();
            }
            /*
            if (radioButtonComputerBackEndLanguages.Checked == true)
            {
                List<Table_Student> listStudentListDataBySpecifiedId = exam_StudentEntities.Table_Student.Where(ListBySpecifiedId => ListBySpecifiedId.ID == 2).ToList();
                dataGridViewStudentInformationAndNoteState.DataSource = listStudentListDataBySpecifiedId;
            }
            if (radioButtonMobileAppDatabaseLanguages.Checked == true)
            {
                List<Table_Student> listStudentListStartNameWithA = exam_StudentEntities.Table_Student.Where(ListStartNameWithA => ListStartNameWithA.First_Name.StartsWith("a")).ToList();
                dataGridViewStudentInformationAndNoteState.DataSource = listStudentListStartNameWithA;
            }
            if (radioButtonComputerAppDatabaseLanguages.Checked == true)
            {
                List<Table_Student> listStudentListEndNameWithA = exam_StudentEntities.Table_Student.Where(ListEndNameWithA => ListEndNameWithA.First_Name.StartsWith("a")).ToList();
                dataGridViewStudentInformationAndNoteState.DataSource = listStudentListEndNameWithA;
            }
            if (radioButtonTotalStudentNumber.Checked == true)
            {
                int total = exam_StudentEntities.Table_Student.Count();
                MessageBox.Show(total.ToString(), " Toplam Öğrenci Sayısı ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radioButtonFirstExamHighestGrade.Checked == true)
            {
                var highestExamNote = exam_StudentEntities.Table_Notes.Max(highestNote => highestNote.Exam_Note_1);
                MessageBox.Show(" 1. Sınavın En Yüksek Notu : " + highestExamNote);
            }
            if (radioButtonFirstExamAverage.Checked == true)
            {
                var highestFirstExamAverage = exam_StudentEntities.Table_Notes.Average(FirstExamAverage => FirstExamAverage.Exam_Note_1);
                MessageBox.Show(" 1. Sınavın Ortalama Notu : " + highestFirstExamAverage);
            }
            */
        }
    }
}
