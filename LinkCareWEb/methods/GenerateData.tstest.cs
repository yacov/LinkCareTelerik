using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace LinkCareWEb
{

    public class GenerateData : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        [CodedStep(@"GenerateID")]
        public void GenerateData_CodedStep()
        {
            Random random = new Random();
                        int indexOfNumber = random.Next(10000, 100000000);
                        var id = string.Format("{0:00000000}", indexOfNumber);
                        int mone = 0, incNum = 0;
                        for (var i = 0; i < 8; i++)
                        {
                            incNum = int.Parse(id[i].ToString());
                            incNum *= (i % 2) + 1;
                            if (incNum > 9)
                                incNum -= 9;
                            mone += incNum;
                        }
                        var checkdigit = 10 - (mone % 10);
                        if (checkdigit == 10) checkdigit = 0;
                        var personalId = id + checkdigit.ToString();
                        Log.WriteLine("Generated ID is "+ personalId);
                        
            SetExtractedValue("generatedID", personalId);
                        int numDoc = random.Next(9999, 99999);
                        var docName = "Doctor"+numDoc;
                        Log.WriteLine("Generated Doctor name is "+ docName);
                        SetExtractedValue("docName", docName);        
                        var docEmail = docName+"@yopmail.com";
                        Log.WriteLine("Generated Doctor Email is "+ docEmail);
                        SetExtractedValue("docEmail", docEmail);
                        
                         int numparent = random.Next(9999, 99999);
                        var parentName = "hore"+numparent;
                        Log.WriteLine("Generated parent name is "+ parentName);
                        SetExtractedValue("parentName", parentName);
                        var parentEmail = parentName+"@yopmail.com";
                        Log.WriteLine("Generated parent Email is "+ parentEmail);
                        SetExtractedValue("parentEmail", parentEmail);
            
             int numteacher = random.Next(9999, 99999);
                        var teacherName = "hore"+numteacher;
                        Log.WriteLine("Generated teacher name is "+ teacherName);
                        SetExtractedValue("teacherName", teacherName);
                        var teacherEmail = teacherName+"@yopmail.com";
                        Log.WriteLine("Generated teacher Email is "+ teacherEmail);
                        SetExtractedValue("teacherEmail", teacherEmail);
        }
    }
}
