using System;
using System.Data;

namespace ClubOrganizer
{
    internal static class Errors
    {
        internal static string EthernetError = "";
        internal static string AuthError = "";
        internal static int Page = 0;
    }

    internal static class RegData
    {
        internal static int id = 0;
        internal static string Lastname = "";
        internal static string Name = "";
        internal static string Secondname = "";
        internal static string Position = "";
        internal static string Login = "";
        internal static string Pass = "";
        internal static string Gender = "";
    }

    internal static class AuthData
    {
        internal static string Login = "";
        internal static string Pass = "";
        internal static bool ok = false;
    }

    internal static class Requisites
    {
        internal static string yr_index = "";
        internal static string yr_city = "";
        internal static string yr_street = "";
        internal static string yr_house = "";
        internal static string yr_flat = "";
        internal static string fc_index = "";
        internal static string fc_city = "";
        internal static string fc_street = "";
        internal static string fc_house = "";
        internal static string fc_flat = "";
        internal static string inn = "";
        internal static string kpp = "";
        internal static string rass = "";
        internal static string korr = "";
        internal static string lastname = "";
        internal static string name = "";
        internal static string secondname = "";
    }

    internal static class Userdata
    {
        internal static int id = 0;
        internal static string Lastname = "";
        internal static string Name = "";
        internal static string Secondname = "";
        internal static string Position = "";
        internal static string Login = "";
        internal static string Pass = "";
        internal static string Gender = "";
    }

    internal static class Users
    {
        internal static DataTable dt_users = new();
        internal static string? id = "";
    }

    internal static class NewDataUser
    {
        internal static int id = 0;
        internal static bool Login_state = false;
        internal static string Lastname = "";
        internal static string Username = "";
        internal static string Secondname = "";
        internal static string Login = "";
        internal static string Pass = "";
        internal static string Gender = "";
        internal static string Position = "";
    }

    internal static class ClientsData
    {
        internal static DataTable lt_clients = new();
        internal static DataTable dt_clients = new();
        internal static string? id = "";
        internal static string fullname = "";
        internal static string reason = "";
        internal static string date = "";
    }

    internal static class BlockData
    {
        internal static DataTable lt_clients = new();
        internal static DataTable dt_clients = new();
        internal static string? id = "";
        internal static string fullname = "";
        internal static string reason = "";
        internal static string date = "";
    }

    internal static class NewClient
    {
        internal static string Lastname = "";
        internal static string Username = "";
        internal static string Secondname = "";
        internal static string Phone = "";
        internal static string Fullname = "";
        internal static string Registration = "";
        internal static string Admin = "";
        internal static string Black = "";

        internal static DataTable lt_clients_last = new();
        internal static DataTable lt_clients_user = new();
        internal static DataTable lt_clients_sec = new();
        internal static DataTable lt_clients_phon = new();
        internal static DataTable dt_clients = new();
        internal static int id = 0;
        internal static int id_ctr = 0;
    }

    internal static class ContractData
    {
        internal static string CtrID = "";
        internal static DateTime DateStart;
        internal static DateTime DateEnd;
        internal static double days = 0;
        internal static double time = 0;
        internal static double HourST = 0;
        internal static double MinST = 0;
        internal static double HourED = 0;
        internal static double MinED = 0;
        internal static DayOfWeek DayOfWeek;
        internal static string price = "";
        internal static string contractPrice = "";
        internal static string contractRest = "";

        internal static string tstart = "";
        internal static string tend = "";
    }

    internal static class ServiceData
    {
        internal static DataTable lt_clients = new();
        internal static DataTable dt_clients = new();
        internal static int id = 0;
        internal static int id_day = 0;

        internal static double totalPrice = 0;
        internal static double totalHour = 0;

        internal static string start = "";
        internal static string end = "";

        internal static string month = "";
        internal static string days = "";
        internal static string hours = "";
        internal static string month_price = "";
    }

    internal static class Contracts
    {
        internal static DataTable dt_contracts = new();
        internal static int id = 0;
        internal static int id_client = 0;

        internal static string rest = "";
        internal static string payRest = "";
        internal static string total = "";

        internal static int endRest = 0;

        internal static string Lastname = "";
        internal static string Name = "";
        internal static string Secondname = "";
        internal static string Phone = "";
        internal static string Fullname = "";
    }

    internal static class Services
    {
        internal static DataTable dt_services = new();
        internal static DataTable dt_days = new();

        internal static int id_ctr = 0;
        internal static int id_ser = 0;

        internal static int count = 0;

        internal static string day = "";
        internal static string start = "";
        internal static string end = "";
        internal static string tstart = "";
        internal static string tend = "";
        internal static string time = "";
        internal static int days = 0;
        internal static string hours = "";
        internal static string price = "";
        internal static string total_price = "";
    }

    internal static class Payments
    {
        internal static DataTable dt_payments = new();
        internal static DataTable lt_clients = new();

        internal static int id = 0;

        internal static string Client = "";

        internal static string Type = "";
        internal static string Name = "";
        internal static string Contract = "";
        internal static string Total = "";
        internal static string Sum = "";
        internal static string Rest = "";
    }
}
