﻿using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MailListener {
    public class MailListener : ITriggerListener {
        public string Name {
            get {
                return "邮件通知";
            }
        }

        public void TriggerComplete(ITrigger trigger, IJobExecutionContext context, SchedulerInstruction triggerInstructionCode) {

        }

        public void TriggerFired(ITrigger trigger, IJobExecutionContext context) {

        }

        public void TriggerMisfired(ITrigger trigger) {

        }

        public bool VetoJobExecution(ITrigger trigger, IJobExecutionContext context) {
            return false;
        }

        private void SendMail(string title, string msg) {
            
        }
    }
}
