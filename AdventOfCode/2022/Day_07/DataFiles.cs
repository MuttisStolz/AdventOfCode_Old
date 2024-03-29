﻿namespace AdventOfCode
{
    public class DataFiles
    {
        public string Name { get; set; }
        public long Size { get; set; }

        public DataFiles(string name, long size)
        {
            Name = name;
            Size = size;
        }

        public override string ToString()
        {
            return $"\t - {this.Name} (file, size={this.Size})";
        }
    }
}
