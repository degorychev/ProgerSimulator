using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgerSimulator
{
    public class Requirements
    {
        public HashSet<int> Education { get; }
        public HashSet<int> Courses { get; }
        public int Skill { get; }
        public Requirements(HashSet<int> EducationForJob, HashSet<int> CoursesForJob, int SkillForJob)
        {
            Education = EducationForJob;
            Courses = CoursesForJob;
            Skill = SkillForJob;
        }
    }
    public class Job
    {
        static public List<Job> GetJobsList()
        {
            List<Job> JobList = new List<Job>();
            
            JobList.Add(new Job("Курьер", 14666, getReqForJob1()));
            JobList.Add(new Job("Оператор ПК", 19857, getReqForJob2()));
            return JobList;
        }
        //Курьер
        static Requirements getReqForJob1()
        {
            HashSet<int> Education = new HashSet<int>();
            HashSet<int> Courses = new HashSet<int>();
            Requirements Job1 = new Requirements(Education, Courses, 0);
            return Job1;
        }
        //Оператор ПК
        static Requirements getReqForJob2()
        {
            HashSet<int> Education = new HashSet<int>();
            HashSet<int> Courses = new HashSet<int>();
            Courses.Add(1);
            Courses.Add(2);
            Requirements Job2 = new Requirements(Education, Courses, 1000);
            return Job2;
        }

        string name; //Должность
        int salary; //Зарплата
        Requirements Requirements; //Требования
        public Job(string NameJob, int SalaryJob, Requirements RequirementsJob)
        {
            name = NameJob;
            salary = SalaryJob;
            Requirements = RequirementsJob;
        }
        public Job(string NameJob, int SalaryJob)
        {
            name = NameJob;
            salary = SalaryJob;
        }
        override public string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(name);
            output.Append(" [");
            output.Append(salary);
            output.Append("]");
            return output.ToString();
        }

        public string ToStringToBlock()
        {
            StringBuilder output = new StringBuilder();
            output.Append(name);
            output.Append("\nЗП: ");
            output.Append(salary);
            output.Append(" р.");
            return output.ToString();
        }

        public bool SkillAnalyze(Requirements CurrentExperience)
        {
            foreach (var item in Requirements.Courses)
                if (!CurrentExperience.Courses.Contains(item))
                    return false;
            foreach (var item in Requirements.Education)
                if (!CurrentExperience.Education.Contains(item))
                    return false;
            if (Requirements.Skill > CurrentExperience.Skill)
                return false;
            return true;
        }

        public string SkillAnalyzeString(Requirements CurrentExperience)
        {
            StringBuilder output = new StringBuilder("Вам необходимы курсы: ");

            foreach (var item in Requirements.Courses)
                if (!CurrentExperience.Courses.Contains(item))
                    output.Append(item.ToString());
            output.Append("\n Вам необходимо образование:");
            foreach (var item in Requirements.Education)
                if (!CurrentExperience.Education.Contains(item))
                    output.Append(item.ToString());
            output.Append("\n Необходимый скил:"+ Requirements.Skill);
            return output.ToString();
        }
    }
}
