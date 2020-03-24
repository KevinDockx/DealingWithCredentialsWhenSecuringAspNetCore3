using System;
using System.Collections.Generic;
using System.Text;

namespace ImageGallery.Model
{
    public class ApplicationUserProfile
    { 
        public Guid Id { get; set; }         
        public string Subject { get; set; } 
        public string SubscriptionLevel { get; set; }
    }
} 