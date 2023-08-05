using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Turbo.az_Desktop_App.Models;

namespace Turbo.az_Desktop_App.Database
{
    internal class MarksDatabase
    {
        //public List<MarksModel?>? marks_1 = new List<MarksModel?>();
        public List<string[]> Marks { get; set; }

        public MarksDatabase()
        {

            Marks = new List<string[]>();
            Marks.Add(new string[] { "aaa", "bbbb", "cccc" });
            Marks.Add(new string[] { "aaa", "bbbb", "cccc" });


        }


    }
    //using FileStream fs_3 = new FileStream("Model.json", FileMode.Open);
    //marks_1 = JsonSerializer.Deserialize<List<MarksModel?>>(fs_3);





}

