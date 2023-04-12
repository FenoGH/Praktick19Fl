namespace Praktick19
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class aeroflotEntities : DbContext
    {
        private static aeroflotEntities context;
        public static aeroflotEntities GetContext()
        {
            if(context == null) context = new aeroflotEntities();
            return context;
        }
    }
}