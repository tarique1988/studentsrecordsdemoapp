using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentDataAccess
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }

        /// <summary>
        /// Constructs a Student object using in_id, in_name, and so on..
        /// </summary>
        /// <param name="in_name">The full name - first middle and last.</param>
        [JsonConstructor]
        public Student(int in_id, string in_name, string in_class, string in_section, string in_contact, string in_address)
        {
            Id = in_id;
            Name = in_name;
            Class = in_class;
            Section = in_section;
            Contact = in_contact;
            Address = in_address;
        }

        /// <summary>
        /// Constructs a student object using a json string
        /// </summary>
        /// <param name="json">A serialized json string representation of a Student object</param>
        public Student(string json)
        {
            Student temp = JsonConvert.DeserializeObject<Student>(json);
            Name = temp.Name;
            Class = temp.Class;
            Id = temp.Id;
            Section = temp.Section;
            Contact = temp.Contact;
            Address = temp.Address;
        }

        public override string ToString()
        {
            return $"{Id},{Name},{Class},{Section},{Contact},{Address}";
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
