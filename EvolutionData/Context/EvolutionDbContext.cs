using EvolutionData.Entities;
using Microsoft.EntityFrameworkCore;

namespace EvolutionData.Context
{
    public partial class EvolutionDbContext : DbContext
    {
        public EvolutionDbContext()
        {
        }

        public EvolutionDbContext(DbContextOptions<EvolutionDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Grupo> Grupos { get; set; }

        public virtual DbSet<Sucursal> Sucursales { get; set; }

        public virtual DbSet<UsuarioEntity> Usuarios { get; set; }

        public virtual DbSet<Vendedor> Vendedores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Database=db_evolution;Username=postgres;Password=letmein");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("pg_catalog", "adminpack");

            modelBuilder.Entity<Grupo>(entity =>
            {
                entity.ToTable("t_grupos");
                entity.HasKey(e => e.Grupoid).HasName("t_grupos_pkey");
                entity.Property(e => e.Grupoid)
                    .ValueGeneratedNever()
                    .HasColumnName("f_codigo_grupo");
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .HasDefaultValueSql("''")
                    .HasColumnName("f_descripcion");
                entity.Property(e => e.Estado)
                    .HasDefaultValueSql("true")
                    .HasColumnName("f_estado");
                entity.Property(e => e.FechaGrupo)
                    .HasDefaultValueSql("to_timestamp((0))")
                    .HasColumnName("f_fecha_grupo");
                entity.Property(e => e.Nombre)
                    .HasMaxLength(150)
                    .HasDefaultValueSql("''")
                    .HasColumnName("f_nombre");
            });

            modelBuilder.Entity<Sucursal>(entity =>
            {
				entity.ToTable("t_sucursal");
				entity.HasKey(e => e.SucursalId).HasName("t_sucursal_pkey");
                entity.Property(e => e.SucursalId)
                    .ValueGeneratedNever()
                    .HasColumnName("f_idsucursal");
                entity.Property(e => e.Direccion)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("''")
                    .HasColumnName("f_direccion");
                entity.Property(e => e.Estado)
                    .HasDefaultValueSql("true")
                    .HasColumnName("f_estado");
                entity.Property(e => e.LabelSucursal)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''")
                    .HasColumnName("f_label_sucursal");
                entity.Property(e => e.Nombre)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''")
                    .HasColumnName("f_nombresucursal");
                entity.Property(e => e.Telefono).HasMaxLength(20).HasDefaultValueSql("''")
                    .HasColumnName("f_telefono");
            });

            modelBuilder.Entity<UsuarioEntity>(entity =>
            {
				entity.ToTable("t_usuario");
				entity.HasKey(e => e.UsuarioId).HasName("t_usuario_pkey");
                entity.HasIndex(e => e.UsuarioId, "t_usuario_f_id_usuario_key").IsUnique();
                entity.Property(e => e.UsuarioId)
                    .ValueGeneratedNever()
                    .HasComment("Código Usuario")
                    .HasColumnName("f_codigo_usuario");
                entity.Property(e => e.AbrirCaja)
                    .HasColumnName("f_abrir_caja");
                entity.Property(e => e.Activo)
                    .HasDefaultValueSql("true")
                    .HasColumnName("f_activo");
                entity.Property(e => e.Apellido)
                    .HasMaxLength(25)
                    .HasDefaultValueSql("''")
                    .HasColumnName("f_apellido");
                entity.Property(e => e.CambiarPrecio)
                    .HasComment("Cambiar Precio")
                    .HasColumnName("f_cambiar_precio");
                entity.Property(e => e.CreaUsuario)
                    .HasComment("Crea Usuario")
                    .HasColumnName("f_crea_usuario");
                entity.Property(e => e.Cuadre)
                    .HasColumnName("f_cuadre");
                entity.Property(e => e.Descuento)
                    .HasColumnName("f_descuento");
                entity.Property(e => e.Direccion)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("''")
                    .HasColumnName("f_direccion");
                entity.Property(e => e.Email).HasMaxLength(60).HasDefaultValueSql("''")
                    .HasColumnName("f_email");
                entity.Property(e => e.EstadoCaja)
                    .HasColumnName("f_estado_caja");
                entity.Property(e => e.FactCredito)
                    .HasColumnName("f_fact_credito");
                entity.Property(e => e.FechaCaducidad)
                    .HasDefaultValueSql("to_timestamp((0))")
                    .HasColumnName("f_fecha_caducidad");
                entity.Property(e => e.GrupoId)
                    .HasColumnName("f_id_grupo");
                entity.Property(e => e.NombreUsuario)
                    .HasMaxLength(60)
                    .HasColumnName("f_id_usuario");
                entity.Property(e => e.Nombre).HasMaxLength(40).HasDefaultValueSql("''")
                    .HasColumnName("f_nombre");
                entity.Property(e => e.Password).HasMaxLength(60).HasDefaultValueSql("''")
                    .HasColumnName("f_password");
                entity.Property(e => e.PermisosLibre)
                    .HasComment("Permisos Libre")
                    .HasColumnName("f_permisos_libre");
                entity.Property(e => e.SucursalId)
                    .HasDefaultValueSql("1")
                    .HasColumnName("f_sucursal");
                entity.Property(e => e.Telefono)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("''")
                    .HasColumnName("f_telefono");
                entity.Property(e => e.VendedorID).HasDefaultValueSql("1")
                    .HasColumnName("f_vendedor");              

                entity.HasOne(u => u.Grupo).WithMany(g => g.Usuarios)
                    .HasForeignKey(d => d.GrupoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("t_usuario_fk");

                entity.HasOne(d => d.Sucursal).WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.SucursalId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("t_usuario_fk1");

                entity.HasOne(d => d.Vendedor).WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.VendedorID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("t_usuario_fk2");
            });

            modelBuilder.Entity<Vendedor>(entity =>
            {
				entity.ToTable("t_vendedores");
				entity.HasKey(e => e.VendedorId).HasName("t_vendedores_pkey");
                entity.Property(e => e.VendedorId)
                    .ValueGeneratedNever()
                    .HasColumnName("f_idvendedor");
                entity.Property(e => e.Activo)
                    .HasComment("Activo")
                    .HasColumnName("f_activo");
                entity.Property(e => e.Apellido)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''")
                    .HasComment("Apellido")
                    .HasColumnName("f_apellido");             
                entity.Property(e => e.Direccion)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("''")
                    .HasComment("Dirección")
                    .HasColumnName("f_direccion");
                entity.Property(e => e.Email)
                    .HasDefaultValueSql("''")
                    .HasComment("Email")
                    .HasColumnType("character varying")
                    .HasColumnName("f_email");
                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''")
                    .HasComment("Nombre")
                    .HasColumnName("f_nombre");
                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''")
                    .HasComment("Teléfono1")
                    .HasColumnName("f_telefono1");
                entity.Property(e => e.Celular)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''")
                    .HasComment("Teléfono2")
                    .HasColumnName("f_telefono2");
                entity.Property(e => e.ZonaId)
                    .HasComment("Id Zona")
                    .HasColumnName("f_zona");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
