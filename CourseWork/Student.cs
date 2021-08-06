using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class Student
    {
        private string _filePath = "studnet.json";
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime RegDate { get; set; }
        [Required]
        public string ContactNo { get; set; }
        [Required]
        public string ProgramEnrol { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string EnrolStatus { get; set; }


        public void Add(Student info)
        {
            Random r = new Random();
            info.Id = r.Next(1000, 9999);
            string data = JsonConvert.SerializeObject(info, Formatting.None);
            Utility.WriteToTextFile(_filePath, data);
        }

        public Student Edit(int id)
        {
            Student obj = new Student();
            return obj;
        }
        public void Edit(Student info)
        {

            //invoking list method of the student class to get student list
            List<Student> list = List();
            //using linq to select student having the specified id
            Student s = list.Where(x => x.Id == info.Id).FirstOrDefault();
            //removing  student object that is to be updated from the list
            list.Remove(s);
            //adding the updated student object to the list
            list.Add(info);
            //converting list of student to string
            string data = JsonConvert.SerializeObject(list, Formatting.None);
            //invoking method of utility class 
            Utility.WriteToTextFile(_filePath, data, false);
        }
        public void Delete(int id)
        {
            //invoking list method of the student class to get student list
            List<Student> list = List();
            //using linq to select student having the specified id
            Student s = list.Where(x => x.Id == id).FirstOrDefault();
            //removing  student object that is to be updated from the list
            list.Remove(s);
            //converting list of student to string
            int count = list.Count;
            string data = JsonConvert.SerializeObject(list, Formatting.None);
            //invoking method of utility class 
            Utility.WriteToTextFile(_filePath, data, false, count);
        }

        public Student Detail(int id)
        {
            Student obj = new Student();
            return obj;
        }
        public List<Student> List()
        {

            string d = Utility.ReadFromTextFile(_filePath);
            if (d != null)
            {
                List<Student> lst = JsonConvert.DeserializeObject<List<Student>>(d);
                return lst;
            }
            return null;
        }
    }

}
