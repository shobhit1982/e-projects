﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elern.Model;
using Elern.Model.User;
using Elern.Model.Institute.Quiz;

namespace Elern.Model.Institute.courses
{
    class QuizSetting : BaseClass
    {
        public virtual CourseMaster Id { get; set; }
        public virtual Users Id { get; set; }

        public int Scoringtype { get; set; }   //  1 for Assign Points to Quiz   2 Assign Points to each Question ( in the quizQuestionMaster )
        public int QuizTotalPoints { get; set; }  // total No assign eg 100 for all question
        
        public int timeTocomplition { get; set; }    // in Minutes -- 0 unlimited time else equal to Value minutes
        public int QuizOrder { get; set; }    //Order of Questions ; 1.Do not shuffled  2.shuffled Question  3.shuffled answers 4.shuffled  question and answer


        public int NoOfQuestions { get; set; }   // no of question in a set
        public virtual ResultType typeId { get; set; }
        
        //*** for Genral setting
        public int Attempts { get; set; }            //  Number of Attempts Allowed: 0 means Unlimited and 1 equal 1 and so on.
        public string QuestionOnPage { get; set; }   
        
        
        //public bool SaveResume { get; set; }     //  Allow Save & Resume:
        //public bool AutoplayVideo { get; set; }     // Autoplay Videos:
        //public bool CourseAvailability { get; set; }   // False : Always    true : Only on certain dates & time
        //public DateTime  CourseAvailStartDate { get; set; }  
        //public DateTime CourseAvailEndDate { get; set; }
        //public bool ChapterAvailability { get; set; }   // False : Always    true : Only on certain dates & time
        //public DateTime ChapterAvailStartDate { get; set; }
        //public DateTime ChapterAvailEndDate { get; set; }
        //public string logo { get; set; }
        //public bool AutoNoChapter { get; set; }        //  Automatically Number Chapter:
        //public int Sidebar { get; set; }                //Sidebar:             1.Disabled         2.Enabled      3. Minimized By default
        public int Exitbuttion { get; set; }            //Show "Exit" button:  1.NO exit Button   2. Exit to course startup page  3 exit
        public string  AfterCompletionPage { get; set; }     // link to completation of courses
        public DateTime MustComplete { get; set; }                                   // Must Complete By:    
        public DateTime completeTill { get; set; }   //Course Completion Compliant Till:

        //*** Security Setting:
        public int securitytype { get; set; }      // 1. Public on the web (Open access) 2.Private access with a link 3.privte Access for select user  and group   4.private Access with a link and course password  
        public bool skipPage { get; set; }         //Allow Skipping Pages
        // Min. Score To Proceed:
        public int downloadAllow { get; set; }    // 1.No   2.private All Pages  3.private select Pages  4.public select Pages
        public bool Disableprint { get; set; }
        public bool Disablecopy { get; set; }

        // trackin                 
        public bool Name { get; set; }
        public bool Email { get; set; }
        public bool Ids { get; set; }
        public bool Phone { get; set; }
        public bool Address { get; set; }
        public bool Askmyquestion { get; set; }  // Ask my own question:
        
        // *** Language
        public string language { get; set; }

        // *** Notifications
        public int Alert { get; set; } // Alert  1.Send me an email when someone takes my courses   2. Email to trainee when they complete this course.
        //public int Alert { get; set; } // Notification via API

        // *** Price
        public int PriceType { get; set; }     //  1.free  2. Paid
        public double coursesFeeMonthly { get; set; }
        public double coursesFeequaterly { get; set; }
        public double coursesFeehalfyearly { get; set; }
        public double coursesFeeannually { get; set; }
        public int freetrial { get; set; }   // for numbers of day
        public string freeDisplaychapter { get; set; }


        // *** Themes
        public string themes { get; set; }
        public string logo { get; set; }
        public string background { set; get; }
        public string fonts { set; get; }
        public string colorChapter { set; get; }
        public string colorPage { set; get; }
        public string colorButton { set; get; }

    }
}
