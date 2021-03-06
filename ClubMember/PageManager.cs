﻿using ClubMember.Images;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;
using System.Windows.Navigation;

namespace ClubMember
{  
    class PageManager
    {
        public static PageManager pagemanager;
        private MembershipPage membershipPage;
        private Login login;
        private PaymentCCPage paymentccpage;
        private PaymentPaypalPage paypalpayment;
        private TicketPaymentCC ticketPaymentCC;
        private TicketPaypal ticketPaypal;
        private ChooseTickets choosetickets;
        private CreateAccount createAccount;
        private ForgotPassword forgotpass;
        private NavigationWindow mainWindow;
        private UpgradeMembershipPage changePlan;
        private Personal personalProfile;
        private Settings settings;
        private BuyTickets buytickets;
        private ItemsBought itemsBought;
        private ProfileSettings profSettings;
        private SendFeedback sendFeedback;
        private About aboutApp;
        private Help help;
        private Person person;
        private ShopOptions shopOptions;
        private NewsFeed newsFeed;
        private Shop shop;
        private Results results;
        private OwnedTickets ownedTickets;
        private TICKET ticket;
        private ShoppingCart shoppingCart;
        private ShopPayment shopPayment;
        public PageManager()
        {
            pagemanager = this;
        }

        public void setPerson(string ID, string password, int daysLeft, string memberType, string fname, string lname, string email, string movie)
        {
            person = new Person(ID, password, daysLeft, memberType, fname, lname, email, movie);
        }

        public Person getPerson()
        {
            return person;
        }

        public void setMembership(String id, int days, String memberPlan)
        {
            membershipPage = new MembershipPage();
            membershipPage.setMemberID(id);
            membershipPage.setDays(days);
            membershipPage.setMemberPlan(memberPlan);
        }
        public void setMainWindow(NavigationWindow window)
        {
            mainWindow = window;
        }
        public NavigationWindow getMainWindow()
        {
            return mainWindow;
        }
        public MembershipPage getMembershipPage()
        {
            return membershipPage;
        }
            
        public void setpaymentCCPage(String _plan)
        {
            paymentccpage = new PaymentCCPage();
            paymentccpage.setPlan(_plan);
        }
        public PaymentCCPage getPaymentCCPage()
        {
            return paymentccpage;
        }
        public void setpaymentPayPalPage(String _plan)
        {
            paypalpayment = new PaymentPaypalPage();
            paypalpayment.setPlan(_plan);
        }
        public PaymentPaypalPage getPaymentPaypalPage()
        {
            return paypalpayment;
        }
        public void setcreateAccount()
        {
            createAccount = new CreateAccount();
        }

        public CreateAccount getCreateAccount()
        {
            return createAccount;
        }

        public void setForgotPassword()
        {
            forgotpass = new ForgotPassword();
        }

        public ForgotPassword getForgotPassword()
        {
            return forgotpass;
        }
        public void setUpgradeMembershipPage(String _plan)
        {
            changePlan = new UpgradeMembershipPage();
            changePlan.setPlan(_plan);
        }
        public UpgradeMembershipPage getUpgradeMembershipPage()
        {
            return changePlan;
        }

        public void setProfile(string fname, string lname, int days)
        {
            personalProfile = new Personal();
            personalProfile.setFname(fname);
            personalProfile.setLname(lname);
            personalProfile.setDaysLeft(days);
        }

        public Personal getProfile()
        {
            return personalProfile;
        }

        public void setSettings()
        {
            settings = new Settings();
        }

        public Settings getSettings()
        {
            return settings;
        }

        public void setLogin()
        {
            login = new Login();
        }

        public Login getLogin()
        {
            return login;
        }

        public void setBuyTickets()
        {
            buytickets = new BuyTickets();
        }

        public BuyTickets getBuyTickets()
        {
            return buytickets;
        }

        public void setChooseTickets()
        {
            choosetickets = new ChooseTickets();
        }

        public ChooseTickets getChooseTickets()
        {
            return choosetickets;
        }

        public void setItemsBought(string memberID)
        {
            itemsBought = new ItemsBought();
            itemsBought.setMemberID(memberID);
        }

        public ItemsBought getItemsBought()
        {
            return itemsBought;
        }

        public void setProfileSettings(string id, string password, string email, string movie)
        {
            profSettings = new ProfileSettings();
            profSettings.setID(id);
            profSettings.setPassword(password);
            profSettings.setEmail(email);
            profSettings.setMovie(movie);
        }

        public ProfileSettings getProfileSettings()
        {
            return profSettings;
        }

        public void setSendFeedback()
        {
            sendFeedback = new SendFeedback();
        }

        public SendFeedback getSendFeedback()
        {
            return sendFeedback;
        }

        public void setAboutApp()
        {
            aboutApp = new About();
        }

        public About getAboutApp()
        {
            return aboutApp;
        }

        public void setHelp()
        {
            help = new Help();
        }

        public Help getHelp()
        {
            return help;
        }
        public void setTicketPayment()
        {
            ticketPaymentCC = new TicketPaymentCC();
        }
        public TicketPaymentCC GetTicketPayment()
        {
            return ticketPaymentCC;
        }

        public void setTicketPaypal()
        {
            ticketPaypal = new TicketPaypal();
        }
        public TicketPaypal GetTicketPaypal()
        {
            return ticketPaypal;
        }
        public void setShopOptions()
        {
            shopOptions = new ShopOptions();
        }
        public ShopOptions GetShopOptions()
        {
            return shopOptions;
        }
        public void setNewsFeed()
        {
            newsFeed = new NewsFeed();
        }
        public NewsFeed GetNewsFeed()
        {
            return newsFeed;
        }

        public void setShop()
        {
            shop = new Shop();
        }
        public Shop getShop()
        {
            return shop;
        }

        public void setResults()
        {
            results = new Results();
        }
        public Results getResults()
        {
            return results;
        }
        public void setOwnedTickets(String memberID)
        {
            ownedTickets = new OwnedTickets();
            ownedTickets.setMemberID(memberID);
        }
        public OwnedTickets getOwnedTickets()
        {
            return ownedTickets;
        }

        public void setTicket(String game, String date, String price, String seat)
        {
            ticket = new TICKET(game, date, price, seat);
        }

        public TICKET getTicket()
        {
            return ticket;
        }

        public void setShoppingCart()
        {
            shoppingCart = new ShoppingCart();
        }

        public ShoppingCart GetShoppingCart()
        {
            return shoppingCart;
        }

        public void setShopPayment()
        {
            shopPayment = new ShopPayment();
        }

        public ShopPayment GetShopPayment()
        {
            return shopPayment;
        }
    }
}
