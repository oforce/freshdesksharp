﻿namespace DBA.FreshdeskSharp.Models
{
    public class FreshdeskTicket : FreshdeskTicket<FreshdeskCustomFields>
    {
        public FreshdeskTicket()
        {
            CustomFields = new FreshdeskCustomFields();
        }
    }

    public class FreshdeskTicket<TCustomFieldObject> : FreshdeskTicketBase, IFreshdeskCustomFields<TCustomFieldObject> where TCustomFieldObject : class
    {
        public TCustomFieldObject CustomFields { get; set; }
    }
}
