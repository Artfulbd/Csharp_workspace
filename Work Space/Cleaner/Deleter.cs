using System;
using System.IO;
using System.Collections.Generic;

public class Deleter
{
	private List<String> deletedFilesList;
	private List<String> extentions;
	private List<String> accessDenied;
	private string dir;
	private bool c_flag;
	private bool sub_flag;
	private bool view_flag;

	public Deleter(string target_dir, List<String> extentions, bool isForC, bool isForSub, bool viewOnly)
	{
		this.dir = target_dir;
		this.extentions = extentions;
		this.c_flag = isForC;
		this.sub_flag = isForSub;
		this.view_flag = viewOnly;
		this.deletedFilesList = new List<string>();
		this.accessDenied = new List<string>();
	}
	
	public List<String> clean()
    {
		if (!isExtentionsCorrect())
			throw new FormatException("Use proper extentions!");
		if (!Directory.Exists(dir))
			throw new DirectoryNotFoundException("No such directory found as " + dir);
		doDeletionJob(this.dir);
		return deletedFilesList;
    }

	public List<String> whoDeniedAccess()
    {
		return accessDenied;

	}

	private bool isExtentionsCorrect()
    {
		if (this.extentions.Count == 0) return false;
		foreach (string ext in this.extentions)
        {
			if (ext[0] != '*')
			{
				return false;
			}
        }
		return true;
    }

	private void doDeletionJob(string target_dir)
    {
		string temp_c, temp_cpp;
		//for files
		foreach(string ext in extentions)
        {
			string[] files = Directory.GetFiles(target_dir, ext);
			if(ext.Equals("*.exe") && c_flag)
            {
				foreach (string file in files)
				{
					temp_c = target_dir + "\\" + Path.GetFileNameWithoutExtension(file) + ".c";
					temp_cpp = target_dir + "\\" + Path.GetFileNameWithoutExtension(file) + ".cpp";
					if (File.Exists(temp_c) || File.Exists(temp_cpp))
					{
						if(!view_flag) File.Delete(file);
						this.deletedFilesList.Add(file);
					}
				}

			}
			else
            {
				foreach (string file in files)
				{
					if (!view_flag) File.Delete(file);
					this.deletedFilesList.Add(file);
				}

			}
			
		}

		//for dir
		if (this.sub_flag)
        {
			string[] dirs = Directory.GetDirectories(target_dir);
			//var dirs = new List<string>(Directory.GetDirectories(target_dir, "*", SearchOption.TopDirectoryOnly));
			foreach (string dir in dirs)
            {
                try
                {
					doDeletionJob(dir);
				}
				catch(Exception e){ accessDenied.Add(dir); }				
			}
		}
	}
}
