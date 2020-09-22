using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TestScheduler.Models;
using System.Globalization;

namespace TestScheduler.Data
{
    public class CourseContext : DbContext
    {
        public CourseContext(DbContextOptions<CourseContext> options) : base(options) { }
        public DbSet<Course> Courses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .ToTable("Courses");
            modelBuilder.Entity<Course>()
                .HasData(
                new Course
                {
                    ID = 1,

                    Module_Code = "BI100100",
                    Module_Description = "D101 Programming Fundamentals",
                    Level = "Level 5"
                },


                new Course
                {
                    ID = 2,

                    Module_Code = "BI100101",
                    Module_Description = "D111 Data Fundamentals",
                    Level = "Level 5"
                },

                new Course
                {
                    ID = 3,

                    Module_Code = "BI100101",
                    Module_Description = "D111 Database Fundamentals",
                    Level = "Level 5"
                },

                new Course
                {
                    ID = 4,

                    Module_Code = "BI100103",
                    Module_Description = "I102 Technical Support Fundamentals",
                    Level = "Level 5"
                },

                new Course
                {
                    ID = 5,

                    Module_Code = "BI100104",
                    Module_Description = "I111 Web Fundamentals",
                    Level = "Level 5"
                },


                new Course
                {
                    ID = 6,

                    Module_Code = "BI100105",
                    Module_Description = "I121 Systems Analysis Fundamentals",
                    Level = "Level 5"
                },



                new Course
                {
                    ID = 7,

                    Module_Code = "BI100106",
                    Module_Description = "T101 Network Fundamentals",
                    Level = "Level 5"
                },

                new Course
                {
                    ID = 8,

                    Module_Code = "BI100107",
                    Module_Description = "T111 Computer Fundamentals",
                    Level = "Level 5"
                },

                new Course
                {
                    ID = 9,

                    Module_Code = "BI100107",
                    Module_Description = "T111 Computer Hardware Fundamentals",
                    Level = "Level 5"
                },

                new Course
                {
                    ID = 10,

                    Module_Code = "BI100108",
                    Module_Description = "I101 Information Systems",
                    Level = "Level 5"
                },

                new Course
                {
                    ID = 11,

                    Module_Code = "BI100108",
                    Module_Description = "I101 Information Systems Fundamentals",
                    Level = "Level 5"
                },


                new Course
                {
                    ID = 12,

                    Module_Code = "BI200201",
                    Module_Description = "I202 IT Project Management",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 13,

                    Module_Code = "BI200202",
                    Module_Description = "D211 Database Development",
                    Level = "Level 6"
                },


                new Course
                {
                    ID = 14,

                    Module_Code = "BI200203",
                    Module_Description = "I221 Analysis and Design",
                    Level = "Level 6"
                },

                new Course
                {
                    ID = 15,

                    Module_Code = "BI200204",
                    Module_Description = "D201 Advanced Programming",
                    Level = "Level 6"
                },

                new Course
                {
                    ID = 16,

                    Module_Code = "BI200205",
                    Module_Description = "D202 Software Process",
                    Level = "Level 6"
                },

                new Course
                {
                    ID = 17,

                    Module_Code = "BI200206",
                    Module_Description = "I211 eCommerce Systems",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 18,

                    Module_Code = "BI200207",
                    Module_Description = "I213 Dynamic Web Solutions",
                    Level = "Level 6"
                },

                new Course
                {
                    ID = 19,

                    Module_Code = "BI200208",
                    Module_Description = "T201 Network Services",
                    Level = "Level 6"
                },


                new Course
                {
                    ID = 20,

                    Module_Code = "BI200211",
                    Module_Description = "T211 Systems Security",
                    Level = "Level 6"
                },

                new Course
                {
                    ID = 21,

                    Module_Code = "BI200212",
                    Module_Description = "I203 Digital Multimedia",
                    Level = "Level 6"
                },

                new Course
                {
                    ID = 22,

                    Module_Code = "BI200213",
                    Module_Description = "T205 Networks (Cisco ITN)",
                    Level = "Level 6"
                },

                new Course
                {
                    ID = 23,

                    Module_Code = "BI200214",
                    Module_Description = "T206 Networks (Cisco RSE)",
                    Level = "Level 6"
                },


                new Course
                {
                    ID = 24,

                    Module_Code = "BI200215",
                    Module_Description = "I209 Industry Placement",
                    Level = "Level 6"
                },


                new Course
                {
                    ID = 25,

                    Module_Code = "BI200216",
                    Module_Description = "I212 Enterprise Data Management",
                    Level = "Level 6"
                },

                new Course
                {
                    ID = 26,

                    Module_Code = "BI200217",
                    Module_Description = "I263 Introduction to Finance",
                    Level = "Level 6"
                },


                new Course
                {
                    ID = 27,

                    Module_Code = "BI200250",
                    Module_Description = "Elective A",
                    Level = "Level 7"
                },

                new Course
                {
                    ID = 28,

                    Module_Code = "BI200251",
                    Module_Description = "Elective B",
                    Level = "Level 7"
                },


                new Course
                {
                    ID = 29,

                    Module_Code = "BI300250",
                    Module_Description = "Elective C",
                    Level = "Level 7"
                },

                new Course
                {
                    ID = 30,

                    Module_Code = "BI300251",
                    Module_Description = "Elective D",
                    Level = "Level 7"
                },

                new Course
                {
                    ID = 31,

                    Module_Code = "BI300300",
                    Module_Description = "I301 Professional Practice",
                    Level = "Level 7"
                },

                new Course
                {
                    ID = 32,

                    Module_Code = "BI300301",
                    Module_Description = "I302 Industry Project",
                    Level = "Level 7"
                },

                new Course
                {
                    ID = 33,

                    Module_Code = "BI300302",
                    Module_Description = "D301 Software Engineering",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 34,

                    Module_Code = "BI300303",
                    Module_Description = "D303 Mobile Application Development",
                    Level = "Level 7"
                },

                new Course
                {
                    ID = 35,

                    Module_Code = "BI300304",
                    Module_Description = "D311 Advanced Database Concepts",
                    Level = "Level 7"
                },

                new Course
                {
                    ID = 36,

                    Module_Code = "BI300305",
                    Module_Description = "I303 Managerial Practice",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 37,

                    Module_Code = "BI300306",
                    Module_Description = "I321 Advanced Systems Analysis",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 38,

                    Module_Code = "BI300307",
                    Module_Description = "I3090000000Topic",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 39,

                    Module_Code = "BI300308",
                    Module_Description = "T301 Network Design",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 40,

                    Module_Code = "BI300309",
                    Module_Description = "T311 System Administration",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 41,

                    Module_Code = "BI300310",
                    Module_Description = "T302 Cisco Scaling and Connecting Networks",
                    Level = "Level 7"
                },

                new Course
                {
                    ID = 42,

                    Module_Code = "BI300312",
                    Module_Description = "I304 Data Analytics and Intelligence",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 43,

                    Module_Code = "BI300313",
                    Module_Description = "I311 Advanced Web Solutions",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 44,

                    Module_Code = "BI300314",
                    Module_Description = "I367 Advanced Project Management",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 45,

                    Module_Code = "BI300315",
                    Module_Description = "T312 Network Security",
                    Level = "Level 7"
                },

                new Course
                {
                    ID = 46,

                    Module_Code = "BI100100",
                    Module_Description = "D101 Programming Fundamentals",
                    Level = "Level 5"
                },
                new Course
                {
                    ID = 47,

                    Module_Code = "BI100101",
                    Module_Description = "D111 Data Fundamentals",
                    Level = "Level 5"
                },
                new Course
                {
                    ID = 48,

                    Module_Code = "BI100101",
                    Module_Description = "D111 Database Fundamentals",
                    Level = "Level 5"
                },

                new Course
                {
                    ID = 49,

                    Module_Code = "BI100103",
                    Module_Description = "I102 Technical Support Fundamentals",
                    Level = "Level 5"
                },
                new Course
                {
                    ID = 50,

                    Module_Code = "BI100104",
                    Module_Description = "I111 Web Fundamentals",
                    Level = "Level 5"
                },
                new Course
                {
                    ID = 51,

                    Module_Code = "BI100105",
                    Module_Description = "I121 Systems Analysis Fundamentals",
                    Level = "Level 5"
                },
                new Course
                {
                    ID = 52,

                    Module_Code = "BI100106",
                    Module_Description = "T101 Network Fundamentals",
                    Level = "Level 5"
                },

                new Course
                {
                    ID = 53,

                    Module_Code = "BI100107",
                    Module_Description = "T111 Computer Fundamentals",
                    Level = "Level 5"
                },

                new Course
                {
                    ID = 54,

                    Module_Code = "BI100107",
                    Module_Description = "T111 Computer Hardware Fundamentals",
                    Level = "Level 5"
                },
                new Course
                {
                    ID = 55,

                    Module_Code = "BI200203",
                    Module_Description = "I221AnalysisndDesign",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 56,

                    Module_Code = "BI100108",
                    Module_Description = "I101 Information Systems",
                    Level = "Level 5"
                },
                new Course
                {
                    ID = 57,

                    Module_Code = "BI100108",
                    Module_Description = "I101 Information Systems Fundamentals",
                    Level = "Level 5"
                },
                new Course
                {
                    ID = 58,

                    Module_Code = "BI200201",
                    Module_Description = "I202 IT Project Management",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 59,

                    Module_Code = "BI200203",
                    Module_Description = "I221 Analysis and Design",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 60,

                    Module_Code = "BI200204",
                    Module_Description = "D201 Advanced Programming",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 61,

                    Module_Code = "BI200205",
                    Module_Description = "D202 Software Process",
                    Level = "Level 6"
                },

                new Course
                {
                    ID = 62,

                    Module_Code = "BI200206",
                    Module_Description = "I211 eCommerce Systems",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 63,

                    Module_Code = "BI200207",
                    Module_Description = "I213 Dynamic Web Solutions",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 64,

                    Module_Code = "BI200208",
                    Module_Description = "T201 Network Services",
                    Level = "Level 6"
                },

                new Course
                {
                    ID = 65,

                    Module_Code = "BI200211",
                    Module_Description = "T211 Systems Security",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 66,

                    Module_Code = "BI200212",
                    Module_Description = "I203 Digital Multimedia",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 67,

                    Module_Code = "BI200213",
                    Module_Description = "T205 Networks (Cisco ITN)",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 68,

                    Module_Code = "BI200214",
                    Module_Description = "T206 Networks (Cisco RSE)",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 69,

                    Module_Code = "BI200215",
                    Module_Description = "I209 Industry Placement",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 70,

                    Module_Code = "BI200216",
                    Module_Description = "I212 Enterprise Data Management",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 71,

                    Module_Code = "BI200217",
                    Module_Description = "I263 Introduction to Finance",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 72,

                    Module_Code = "BI200250",
                    Module_Description = "Elective A",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 73,

                    Module_Code = "BI200251",
                    Module_Description = "Elective B",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 74,

                    Module_Code = "BI300250",
                    Module_Description = "Elective C",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 75,

                    Module_Code = "BI300251",
                    Module_Description = "Elective D",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 76,

                    Module_Code = "BI300300",
                    Module_Description = "I301 Professional Practice",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 77,

                    Module_Code = "BI300301",
                    Module_Description = "I302 Industry Project",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 78,

                    Module_Code = "BI300302",
                    Module_Description = "D301 Software Engineering",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 79,

                    Module_Code = "BI300303",
                    Module_Description = "D303 Mobile Application Development",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 80,

                    Module_Code = "BI300304",
                    Module_Description = "D311 Advanced Database Concepts",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 81,

                    Module_Code = "BI300305",
                    Module_Description = "I303 Managerial Practice",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 82,

                    Module_Code = "BI300306",
                    Module_Description = "I321 Advanced Systems Analysis",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 83,

                    Module_Code = "BI300307",
                    Module_Description = "I309 Special Topic",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 84,

                    Module_Code = "BI300308",
                    Module_Description = "T301 Network Design",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 85,

                    Module_Code = "BI100106",
                    Module_Description = "T101 Network Fundamentals",
                    Level = "Level 5"
                },
                new Course
                {
                    ID = 86,

                    Module_Code = "BI300310",
                    Module_Description = "T302 Cisco Scaling and Connecting Networks",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 87,

                    Module_Code = "BI300312",
                    Module_Description = "I304 Data Analytics and Intelligence",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 88,

                    Module_Code = "BI300313",
                    Module_Description = "I311 Advanced Web Solutions",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 89,

                    Module_Code = "BI300314",
                    Module_Description = "I367 Advanced Project Management",
                    Level = "Level 7"
                },

                new Course
                {
                    ID = 90,

                    Module_Code = "BI300315",
                    Module_Description = "T312 Network Security",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 91,

                    Module_Code = "BI100100",
                    Module_Description = "D101 Programming Fundamentals",
                    Level = "Level 5"
                },
                new Course
                {
                    ID = 92,

                    Module_Code = "BI100101",
                    Module_Description = "D111 Data Fundamentals",
                    Level = "Level 5"
                },
                new Course
                {
                    ID = 93,

                    Module_Code = "BI100101",
                    Module_Description = "D111 Database Fundamentals",
                    Level = "Level 5"
                },
                new Course
                {
                    ID = 94,

                    Module_Code = "BI100103",
                    Module_Description = "I102 Technical Support Fundamentals",
                    Level = "Level 5"
                },
                new Course
                {
                    ID = 95,

                    Module_Code = "BI100104",
                    Module_Description = "I111 Web Fundamentals",
                    Level = "Level 5"
                },
                new Course
                {
                    ID = 96,

                    Module_Code = "BI100105",
                    Module_Description = "I121 Systems Analysis Fundamentals",
                    Level = "Level 5"
                },
                new Course
                {
                    ID = 97,

                    Module_Code = "BI100106",
                    Module_Description = "T101 Network Fundamentals",
                    Level = "Level 5"
                },
                new Course
                {
                    ID = 98,

                    Module_Code = "BI100107",
                    Module_Description = "T111 Computer Fundamentals",
                    Level = "Level 5"
                },
                new Course
                {
                    ID = 99,

                    Module_Code = "BI100107",
                    Module_Description = "T111 Computer Hardware Fundamentals",
                    Level = "Level 5"
                },
                new Course
                {
                    ID = 100,

                    Module_Code = "BI100108",
                    Module_Description = "I101 Information Systems",
                    Level = "Level 5"
                },
                new Course
                {
                    ID = 101,

                    Module_Code = "BI100108",
                    Module_Description = "I101 Information Systems Fundamentals",
                    Level = "Level 5"
                },
                new Course
                {
                    ID = 102,

                    Module_Code = "BI200201",
                    Module_Description = "I202 IT Project Management",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 103,

                    Module_Code = "BI200202",
                    Module_Description = "D211 Database Development",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 104,

                    Module_Code = "BI200203",
                    Module_Description = "I221 Analysis and Design",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 105,

                    Module_Code = "BI200204",
                    Module_Description = "D201 Advanced Programming",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 106,

                    Module_Code = "BI200205",
                    Module_Description = "D202 Software Process",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 107,

                    Module_Code = "BI200206",
                    Module_Description = "I211 eCommerce Systems",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 108,

                    Module_Code = "BI200207",
                    Module_Description = "I213 Dynamic Web Solutions",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 109,

                    Module_Code = "BI200251",
                    Module_Description = "Elective B",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 110,

                    Module_Code = "BI200208",
                    Module_Description = "T211 Systems Security",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 111,

                    Module_Code = "BI200212",
                    Module_Description = "I203 Digital Multimedia",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 112,

                    Module_Code = "BI200213",
                    Module_Description = "T205 Networks (Cisco ITN)",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 113,

                    Module_Code = "BI200214",
                    Module_Description = "T206 Networks (Cisco RSE)",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 114,

                    Module_Code = "BI200215",
                    Module_Description = "I209 Industry Placement",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 115,

                    Module_Code = "BI200216",
                    Module_Description = "I212 Enterprise Data Management",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 116,

                    Module_Code = "BI200217",
                    Module_Description = "I263 Introduction to Finance",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 117,

                    Module_Code = "BI200250",
                    Module_Description = "Elective A",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 118,

                    Module_Code = "BI200251",
                    Module_Description = "Elective B",
                    Level = "Level 6"
                },
                new Course
                {
                    ID = 119,

                    Module_Code = "BI300250",
                    Module_Description = "Elective C",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 120,

                    Module_Code = "BI300251",
                    Module_Description = "Elective D",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 121,

                    Module_Code = "BI300300",
                    Module_Description = "I301 Professional Practice",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 122,

                    Module_Code = "BI300301",
                    Module_Description = "I302 Industry Project",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 123,

                    Module_Code = "BI300302",
                    Module_Description = "D301 Software Engineering",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 124,

                    Module_Code = "BI300303",
                    Module_Description = "D303 Mobile Application Development",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 125,

                    Module_Code = "BI300304",
                    Module_Description = "D311 Advanced Database Concepts",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 126,

                    Module_Code = "BI300305",
                    Module_Description = "I303 Managerial Practice",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 127,

                    Module_Code = "BI300306",
                    Module_Description = "I321 Advanced Systems Analysis",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 128,

                    Module_Code = "BI300307",
                    Module_Description = "I309 Special Topic",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 129,

                    Module_Code = "BI300308",
                    Module_Description = "T301 Network Design",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 130,

                    Module_Code = "BI300309",
                    Module_Description = "T311 System Administration",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 131,

                    Module_Code = "BI300310",
                    Module_Description = "T302 Cisco Scaling and Connecting Networks",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 132,

                    Module_Code = "BI300312",
                    Module_Description = "I304 Data Analytics and Intelligence",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 133,

                    Module_Code = "BI300313",
                    Module_Description = "I311 Advanced Web Solutions",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 134,

                    Module_Code = "BI300314",
                    Module_Description = "I367 Advanced Project Management",
                    Level = "Level 7"
                },
                new Course
                {
                    ID = 135,

                    Module_Code = "BI300315",
                    Module_Description = "T312 Network Security",
                    Level = "Level 7"
                }
                );
        }
    }

}
