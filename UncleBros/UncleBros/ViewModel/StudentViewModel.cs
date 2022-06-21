using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using UncleBros.Model;
using Xamarin.Forms;

namespace UncleBros.ViewModel
{
    internal class StudentViewModel
    {
        int studentId = 0;
        string[] arrName = new string[] { "Kim", "Lee", "Park", "Choi", "Kang", "Ko", "Bu" };
        string[] arrMajor = new string[] { "Korean", "Japanese", "Chinese", "English", "Computer", "Science" };
        char[] arrGender = new char[] { 'M', 'W' };
        string[] arrGrade = new string[] { "A+", "A", "B+", "B", "C+", "C", "D+", "D", "F" };
        int[] arrAge = new int[] { 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };

        Random random = null;

        ObservableCollection<Student> students = new ObservableCollection<Student>();

        public StudentViewModel()
        {
            random = new Random();

            // 초기 학생 등록
            for (int i = 0; i < 3; i++)
            {
                students.Add(CreateStudent());
            }

            // 추가 학생 등록
            Device.StartTimer(TimeSpan.FromSeconds(30), () =>
            {
                students.Add(CreateStudent());
                return true;
            });
        }

        private Student CreateStudent()
        {
            return new Student(
                    ++studentId,
                    arrName[random.Next(0, arrName.Length - 1)],
                    arrMajor[random.Next(0, arrMajor.Length - 1)],
                    arrGender[random.Next(0, arrGender.Length - 1)],
                    arrGrade[random.Next(0, arrGrade.Length - 1)],
                    arrAge[random.Next(0, arrAge.Length - 1)]
                    );
        }

        public ObservableCollection<Student> Students
        {
            get { return students; }
            set { students = value; }
        }
    }
}
