using Staff_hub_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Staff_hub_api.Services
{
    public static class StaffGroupService
    {
        public static Models.StaffGroup[] StaffGroupList = new StaffGroup[]
        {  
             new StaffGroup {Id = 1,  GroupName = "Modern WorkPlace", 
               TeamMembers = new MemberShift[] { 
                   new MemberShift {MemberName = "Dao David", Email = "xxxx@infeeny.com", Shifts = new Shift[]{ }} ,
                   new MemberShift {MemberName = "Gaelle Fernandez" ,Email = "xxxx@infeeny.com", Shifts = new Shift[]{ } } ,
                   new MemberShift {MemberName = "Brice Muroni" ,Email = "xxxx@infeeny.com", Shifts = new Shift[]{ } } ,
                   new MemberShift {MemberName = "Antoine Le Carpentier" ,Email = "xxxx@infeeny.com", Shifts = new Shift[]{ } } ,
                   new MemberShift {MemberName = "Sylvain Grange" ,Email = "xxxx@infeeny.com", Shifts = new Shift[]{ } } ,
                   new MemberShift {MemberName = "Pauline Console" ,Email = "xxxx@infeeny.com", Shifts = new Shift[]{ } } ,
                   new MemberShift {MemberName = "Fiona Fruhinsholz" ,Email = "xxxx@infeeny.com", Shifts = new Shift[]{ } } ,
                   new MemberShift {MemberName = "Angela Florez" ,Email = "xxxx@infeeny.com", Shifts = new Shift[]{ } } ,
                   new MemberShift {MemberName = "Blandine Pinto" ,Email = "xxxx@infeeny.com", Shifts = new Shift[]{ } } 
               }
             },
             new StaffGroup {Id = 2,  GroupName = "Developpement .Net",
               TeamMembers = new MemberShift[] {
                   new MemberShift {MemberName = "Anthony ALLIOT" , Email = "xxxx@infeeny.com", Shifts = new Shift[]{ } } ,
                   new MemberShift {MemberName = "Patrick VILLARD", Email = "xxxx@infeeny.com", Shifts = new Shift[]{ } } ,
                   new MemberShift {MemberName = "Sébastien LE BOUEDEC" , Email = "xxxx@infeeny.com", Shifts = new Shift[]{ } } ,
               }
             }
        };

        public static StaffGroup[] getStaffGroups()
        {
            return StaffGroupList;
        }

        public static StaffGroup getStaffGroupById(int _id)
        {
            return StaffGroupList.Where(s => s.Id == _id).FirstOrDefault();
        }
        public static StaffGroup getStaffGroupMonthShift(int _id, int _month)
        {
            /*
            StaffGroup gr = StaffGroupList.Where(s => s.Id == _id).FirstOrDefault();
            Shift[] shift1;
            Shift[] shift3;
            Shift[] shift4;
            switch (_month)
            {
                case 1:
                    shift1 = new Shift[] {
                        new Shift {Id="toto01", ClientId= 1, Color= "#240058", EndDate= "2019-01-12T23=00=00.000Z", StartDate= "2019-10-09T23=00=00.000Z", Title= "sec 09/10-12/11",
                                StartDay= 1, StartMonth= 10, StartYear= 2019, EndDay= 1, EndMonth= 10,  EndYear= 2019 },
                        new Shift {Id="toto01", ClientId= 1, Color= "#240058", EndDate= "2019-03-13T23=00=00.000Z", StartDate= "2019-10-09T23=00=00.000Z", Title= "sec 09/10-12/11",
                                StartDay= 1, StartMonth= 10, StartYear= 2019, EndDay= 1, EndMonth= 10,  EndYear= 2019 },
                        };
                    break;
            }

            Shift[] janvierShift 
            */

            return StaffGroupList.Where(s => s.Id == _id).FirstOrDefault();
        }
    }
}
