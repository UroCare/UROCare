using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
namespace SHC.UROCare.UROCareDataModel
{
    public interface IUROCareEntities : IObjectContextAdapter, IDisposable
    {
        DbSet<Andrology> Andrologies { get; set; }
        DbSet<Doctors_List> Doctors_List { get; set; }
        DbSet<ESWL> ESWLs { get; set; }
        DbSet<Follow_Up> Follow_Up { get; set; }
        DbSet<Investigation> Investigations { get; set; }
        DbSet<IPD> IPDs { get; set; }
        DbSet<Operation_Dtls> Operation_Dtls { get; set; }
        DbSet<Param_Dtls> Param_Dtls { get; set; }
        DbSet<Param_Master> Param_Master { get; set; }
        DbSet<Patient_Examination> Patient_Examination { get; set; }
        DbSet<Patient_Info> Patient_Info { get; set; }
        DbSet<Prescription_Template> Prescription_Template { get; set; }
        DbSet<Treatement_Dtls> Treatement_Dtls { get; set; }
        DbSet<Treatment_Advised> Treatment_Advised { get; set; }
        DbSet<UD> UDS { get; set; }
        DbSet<Urology_History> Urology_History { get; set; }
        DbSet<User_Master> User_Master { get; set; }
        DbSet<XRayImage> XRayImages { get; set; }

        int SaveChanges();
    }
}
