
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Leadtools;
using Leadtools.Codecs;
using Leadtools.Document.Writer;
using Leadtools.Svg;
//using LeadtoolsExamples.Common;
using Leadtools.Document;
using Leadtools.Caching;
using Leadtools.Annotations.Engine;
using Leadtools.Ocr;
using Leadtools.Document.Converter;
using System.IO;

namespace ConvertTestWithCore
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentConverterExample();
        }
        static void DocumentConverterExample()
        {
            string path = @"C:\Users\Dell\Desktop\";
            using (DocumentConverter documentConverter = new DocumentConverter())
            {
                var inFile = Path.Combine(path, @"TestDoc.docx");
                var outFile = Path.Combine(path, @"output.pdf");
                var format = DocumentFormat.Pdf;
                var jobData = DocumentConverterJobs.CreateJobData(inFile, outFile, format);
                jobData.JobName = "conversion job";

                var job = documentConverter.Jobs.CreateJob(jobData);
                documentConverter.Jobs.RunJob(job);

                if (job.Status == DocumentConverterJobStatus.Success)
                {
                    Console.WriteLine("Success");
                }
                else
                {
                    Console.WriteLine("{0} Errors", job.Status);
                    foreach (var error in job.Errors)
                    {
                        Console.WriteLine("  {0} at {1}: {2}", error.Operation, error.InputDocumentPageNumber, error.Error.Message);
                    }
                }
            }
        }
    }


}

