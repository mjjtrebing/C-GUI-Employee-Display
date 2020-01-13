/* Author: Matt Trebing
 * form1.cs
 * 2/12/19
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; //I added <-- uses regex

namespace Employee_Dispay
{

    public partial class Form1 : Form
    {
        public EIS.SimpleEmpInfoServiceSoapClient EISclient = new EIS.SimpleEmpInfoServiceSoapClient("SimpleEmpInfoServiceSoap");

        public Form1()
        { 
            InitializeComponent();

        }

        private void caller_Click(object sender, EventArgs e)
        {
            //100157 <-- newbie jones
            String testID = "100157";
            EIS.Employee passer = EISclient.getEmployee(testID);

            firstCall.Text = passer.FirstName;

        }

        private void firstCall_TextChanged(object sender, EventArgs e)
        {
            //firstCall.Text = "Asf";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            empList.DataSource = EISclient.getEmployeesList();
            empList.DisplayMember = "FULLNAME";
            empList.ValueMember = "FULLNAME";

            //String testID = "100157";
            //EIS.Employee topEmployee = EISclient.getEmployee(testID);

            //empList.SelectedIndex = empList.FindString(topEmployee.FirstName);
        }

        private void empList_SelectedIndexChanged(object sender, EventArgs e)
        {
            String resultString = "100157";
            resultString = Regex.Match(empList.Text, @"\d+").Value;

            EIS.Employee selected = EISclient.getEmployee(resultString);
            populatePersonalInfo(selected);
            populateContactInfo(selected);
            populatePositionInfo(selected);
            populateWagesInfo(selected);
            
        }
        private void populatePersonalInfo(EIS.Employee selected)
        {
            //EIS.Employee selected = EISclient.getEmployee(empList.Text);
            firstCall.Text = selected.FirstName + " ";
            firstCall.Text += selected.MiddleInitial + ". ";
            firstCall.Text += selected.LastName;

            emp.Text = selected.FirstName + " ";
            emp.Text += selected.MiddleInitial + ". ";
            emp.Text += selected.LastName;

            if (selected.DateOfBirth != null)
            {
                birth.Text = selected.DateOfBirth.ToString();
            }
            if (selected.Gender != null)
            {
                if (selected.Gender.Equals("M"))
                {
                    male.Checked = true;
                    female.Checked = false;
                }
                if (selected.Gender.Equals("F"))
                {
                    female.Checked = true;
                    male.Checked = false;
                }
            }

            EIN.Text = selected.EIN;
            SSN.Text = selected.SSN;
        }

        private void populateContactInfo(EIS.Employee selected)
        {
            home.Text = selected.HomePhone;
            work.Text = selected.WorkPhone;
            cell.Text = selected.CellPhone;
            location.Text = selected.OfficeLocation;
            street.Text = selected.StreetAddress;
            zip.Text = selected.Zip;
            city.Text = selected.City;
            state.Text = selected.State;

        }

        private void populatePositionInfo(EIS.Employee selected)
        {
            hired.Text = selected.DateHired.ToString();
            dpt.Text = selected.DeptCode;
            type.Text = selected.EmployeeType;
            title.Text = selected.Title;
            SEIN.Text = selected.Title;
        }

        private void populateWagesInfo(EIS.Employee selected)
        {
            sal.Text = selected.SalaryOrWage.ToString();
            exemption.Text = selected.TaxExemptions.ToString();
            status.Text = selected.TaxFilingStatus;
            witholdings.Text = selected.ExtraWithholdings.ToString();
            raise.Text = selected.DateOfLastRaise.ToString();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
