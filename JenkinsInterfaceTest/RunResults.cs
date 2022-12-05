using System;

namespace JenkinsInterfaceTest
{
    public class RunResults
    {
        public string BuildNumMain;
        public bool In_Progress;
        public bool Result;
        public string Url;
        public string BuiltOn;
        public DateTime DT;
        public RunResults() { }
        public RunResults(string buildnumbermain,  bool in_progress, bool result, string url, string runbuilton, DateTime built_timestamp)
        {
            BuildNumMain = buildnumbermain;
            In_Progress= in_progress;
            Result = result;
            Url =  url;
            BuiltOn = runbuilton;
            DT = built_timestamp;
        }

        public string BuildNum
        { 
            get { return BuildNumMain; }
            set { BuildNumMain = value; }
        }
    
            
        public bool in_progress
        {
            get { return In_Progress; }
            set { In_Progress = value; }            
        }
 
        public bool result
        { 
            get { return Result; }
            set { Result = value; }       
        }

        public string url
        { 
            get { return Url; }
            set { Url = value; }
        }   
        public string runbuilton
        { 
            get { return BuiltOn; }
            set {  BuiltOn = value; } 
        }
        public DateTime built_timestamp
        { 
            get { return DT; }
            set {  DT = value; }
        }
    }
}
