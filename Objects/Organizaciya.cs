﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UKTIO_App
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Organizaciya.
    /// </summary>
    // *** Start programmer edit section *** (Organizaciya CustomAttributes)

    // *** End programmer edit section *** (Organizaciya CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("OrganizaciyaE", new string[] {
            "Nazvanie as \'Название\'"})]
    [View("OrganizaciyaL", new string[] {
            "Nazvanie as \'Название\'"})]
    public class Organizaciya : ICSSoft.STORMNET.DataObject
    {
        
        private string fNazvanie;
        
        // *** Start programmer edit section *** (Organizaciya CustomMembers)

        // *** End programmer edit section *** (Organizaciya CustomMembers)

        
        /// <summary>
        /// Nazvanie.
        /// </summary>
        // *** Start programmer edit section *** (Organizaciya.Nazvanie CustomAttributes)

        // *** End programmer edit section *** (Organizaciya.Nazvanie CustomAttributes)
        [StrLen(255)]
        [NotNull()]
        public virtual string Nazvanie
        {
            get
            {
                // *** Start programmer edit section *** (Organizaciya.Nazvanie Get start)

                // *** End programmer edit section *** (Organizaciya.Nazvanie Get start)
                string result = this.fNazvanie;
                // *** Start programmer edit section *** (Organizaciya.Nazvanie Get end)

                // *** End programmer edit section *** (Organizaciya.Nazvanie Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Organizaciya.Nazvanie Set start)

                // *** End programmer edit section *** (Organizaciya.Nazvanie Set start)
                this.fNazvanie = value;
                // *** Start programmer edit section *** (Organizaciya.Nazvanie Set end)

                // *** End programmer edit section *** (Organizaciya.Nazvanie Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "OrganizaciyaE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View OrganizaciyaE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("OrganizaciyaE", typeof(UKTIO_App.Organizaciya));
                }
            }
            
            /// <summary>
            /// "OrganizaciyaL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View OrganizaciyaL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("OrganizaciyaL", typeof(UKTIO_App.Organizaciya));
                }
            }
        }
    }
}
