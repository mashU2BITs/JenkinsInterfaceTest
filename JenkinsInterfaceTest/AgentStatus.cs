using System;
using System.Collections.Generic;
using System.Text;

namespace JenkinsInterfaceTest
{
    public class AgentStatus
    {
        public string AvailablePhysicalMemory;
        public string AvailableSwapSpace;
        public bool Offline;
        public string TotalPhysicalMemory;
        public string TotalSwapSpace;
        public string DisplayName;

        public AgentStatus() { }
        public AgentStatus(string availablePhysicalMemory, string availableSwapSpace, bool offline, string totalPhysicalMemory, string totalSwapSpace, string displayName)
        {
            AvailablePhysicalMemory = availablePhysicalMemory;
            AvailableSwapSpace = availableSwapSpace;
            Offline = offline;
            TotalPhysicalMemory = totalPhysicalMemory;
            TotalSwapSpace = totalSwapSpace;
            DisplayName = displayName;
        }

        public string availablePhysicalMemory
        {
            get { return AvailablePhysicalMemory; }
            set { AvailablePhysicalMemory = value; }
        }
        public string availableSwapSpace
        {
            get { return AvailableSwapSpace; }
            set { AvailableSwapSpace = value; }
        }
        public string totalSwapSpace
        {
            get { return TotalSwapSpace; }
            set { TotalSwapSpace = value; }
        }

        public bool offline
        {
            get { return Offline; }
            set {   Offline = value;  }
        }
        public string totalPhysicalMemory
        {
            get { return TotalPhysicalMemory; }
            set { TotalPhysicalMemory = value; }
        }
        public string displayName
        {
            get { return DisplayName; }
            set { DisplayName = value; }
        }
    }
}
