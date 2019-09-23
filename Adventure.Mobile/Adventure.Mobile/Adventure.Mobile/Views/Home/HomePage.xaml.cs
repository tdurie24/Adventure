using System;
using System.Collections.ObjectModel;
using Adventure.Mobile.Models;
using Adventure.Mobile.ViewModels.Home;
using Xamarin.Forms;

namespace Adventure.Mobile.Views.Home
{
    public partial class HomePage : ContentPage
    {
        public HomePageViewModel VM { get; set; }
        public HomePage()
        {
            InitializeComponent();
            VM = new HomePageViewModel();
            VM.Sections = new ObservableCollection<FeaturedHolidaysModel>
            {
                new FeaturedHolidaysModel
                {
                    Name= "The Pavilion Hotel",
                    City = "Durban",
                    ShortDescription="This property is ideally situated minutes away from Durban's iconic beach front and promenade",
                    DateFrom ="01 October 2019",
                    DateTo = "30 November",
                    Price = "R3,350",
                    Image = "https://media-cdn.tripadvisor.com/media/photo-s/03/93/82/40/pavilion-hotel.jpg"
                    
                    //Header = "Thank you for participating in the CarouselView Challenge!",
                    //Content = new FormattedString
                    //{
                    //    Spans =
                    //    {
                    //        new Span
                    //        {
                    //            Text = "Your feedback is highly valuable for helping to drive CarouselView's development and highlight functionality you need most." + Environment.NewLine + Environment.NewLine
                    //        },
                    //        new Span
                    //        {
                    //            Text = "(This is a CarouselView, so swipe to the left to keep reading!)",
                    //            FontAttributes = FontAttributes.Italic
                    //        }
                    //    }
                    //}
                },
                new FeaturedHolidaysModel
                {
                    Name= "The Pavilion Hotel",
                    City = "Durban",
                    ShortDescription="This property is ideally situated minutes away from Durban's iconic beach front and promenade",
                    DateFrom ="01 October 2019",
                    DateTo = "30 November",
                    Price = "R3,350",
                    Image = "https://www.flightcentre.co.za/sites/default/files/styles/product-200x200/global/product-images/Durban_Light_House_shutterstock_91925297200-e8a005d004ba5b391e75ad40e47a3e1a.jpg?itok=U6rT1Ha1"

                },
                new FeaturedHolidaysModel
                {
                    Name= "The Pavilion Hotel",
                    City = "Durban",
                    ShortDescription="This property is ideally situated minutes away from Durban's iconic beach front and promenade",
                    DateFrom ="01 October 2019",
                    DateTo = "30 November",
                    Price = "R3,350",
                    Image = "https://www.flightcentre.co.za/sites/default/files/styles/product-200x200/global/product-images/Durban_Light_House_shutterstock_91925297200-e8a005d004ba5b391e75ad40e47a3e1a.jpg?itok=U6rT1Ha1"

                },
                new FeaturedHolidaysModel
                {
                    Name= "The Pavilion Hotel",
                    City = "Durban",
                    ShortDescription="This property is ideally situated minutes away from Durban's iconic beach front and promenade",
                    DateFrom ="01 October 2019",
                    DateTo = "30 November",
                    Price = "R3,350",
                    Image = "https://www.flightcentre.co.za/sites/default/files/styles/product-200x200/global/product-images/Durban_Light_House_shutterstock_91925297200-e8a005d004ba5b391e75ad40e47a3e1a.jpg?itok=U6rT1Ha1"

                },
                new FeaturedHolidaysModel
                {
                   Name= "The Pavilion Hotel",
                    City = "Durban",
                    ShortDescription="This property is ideally situated minutes away from Durban's iconic beach front and promenade",
                    DateFrom ="01 October 2019",
                    DateTo = "30 November",
                    Price = "R3,350",
                    Image = "https://www.flightcentre.co.za/sites/default/files/styles/product-200x200/global/product-images/Durban_Light_House_shutterstock_91925297200-e8a005d004ba5b391e75ad40e47a3e1a.jpg?itok=U6rT1Ha1"

                },
            };
            BindingContext = VM;
        }
    }
}
