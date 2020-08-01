﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("EmployeeModel", "DepartmentEmployee", "Department", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(EFAppli2.Department), "Employee", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(EFAppli2.Employee), true)]

#endregion

namespace EFAppli2
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class EmployeeModelContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new EmployeeModelContainer object using the connection string found in the 'EmployeeModelContainer' section of the application configuration file.
        /// </summary>
        public EmployeeModelContainer() : base("name=EmployeeModelContainer", "EmployeeModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EmployeeModelContainer object.
        /// </summary>
        public EmployeeModelContainer(string connectionString) : base(connectionString, "EmployeeModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EmployeeModelContainer object.
        /// </summary>
        public EmployeeModelContainer(EntityConnection connection) : base(connection, "EmployeeModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Department> Departments
        {
            get
            {
                if ((_Departments == null))
                {
                    _Departments = base.CreateObjectSet<Department>("Departments");
                }
                return _Departments;
            }
        }
        private ObjectSet<Department> _Departments;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Employee> Employees
        {
            get
            {
                if ((_Employees == null))
                {
                    _Employees = base.CreateObjectSet<Employee>("Employees");
                }
                return _Employees;
            }
        }
        private ObjectSet<Employee> _Employees;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Departments EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToDepartments(Department department)
        {
            base.AddObject("Departments", department);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Employees EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEmployees(Employee employee)
        {
            base.AddObject("Employees", employee);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EmployeeModel", Name="Department")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Department : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Department object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="location">Initial value of the Location property.</param>
        public static Department CreateDepartment(global::System.Int32 id, global::System.String name, global::System.String location)
        {
            Department department = new Department();
            department.Id = id;
            department.Name = name;
            department.Location = location;
            return department;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false, "Name");
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Location
        {
            get
            {
                return _Location;
            }
            set
            {
                OnLocationChanging(value);
                ReportPropertyChanging("Location");
                _Location = StructuralObject.SetValidValue(value, false, "Location");
                ReportPropertyChanged("Location");
                OnLocationChanged();
            }
        }
        private global::System.String _Location;
        partial void OnLocationChanging(global::System.String value);
        partial void OnLocationChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EmployeeModel", "DepartmentEmployee", "Employee")]
        public EntityCollection<Employee> Employees
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Employee>("EmployeeModel.DepartmentEmployee", "Employee");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Employee>("EmployeeModel.DepartmentEmployee", "Employee", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EmployeeModel", Name="Employee")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Employee : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Employee object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="firstName">Initial value of the FirstName property.</param>
        /// <param name="lastName">Initial value of the LastName property.</param>
        /// <param name="gender">Initial value of the Gender property.</param>
        /// <param name="salary">Initial value of the Salary property.</param>
        /// <param name="departmentId">Initial value of the DepartmentId property.</param>
        public static Employee CreateEmployee(global::System.Int32 id, global::System.String firstName, global::System.String lastName, global::System.String gender, global::System.Int32 salary, global::System.Int32 departmentId)
        {
            Employee employee = new Employee();
            employee.Id = id;
            employee.FirstName = firstName;
            employee.LastName = lastName;
            employee.Gender = gender;
            employee.Salary = salary;
            employee.DepartmentId = departmentId;
            return employee;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, false, "FirstName");
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, false, "LastName");
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Gender
        {
            get
            {
                return _Gender;
            }
            set
            {
                OnGenderChanging(value);
                ReportPropertyChanging("Gender");
                _Gender = StructuralObject.SetValidValue(value, false, "Gender");
                ReportPropertyChanged("Gender");
                OnGenderChanged();
            }
        }
        private global::System.String _Gender;
        partial void OnGenderChanging(global::System.String value);
        partial void OnGenderChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Salary
        {
            get
            {
                return _Salary;
            }
            set
            {
                OnSalaryChanging(value);
                ReportPropertyChanging("Salary");
                _Salary = StructuralObject.SetValidValue(value, "Salary");
                ReportPropertyChanged("Salary");
                OnSalaryChanged();
            }
        }
        private global::System.Int32 _Salary;
        partial void OnSalaryChanging(global::System.Int32 value);
        partial void OnSalaryChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 DepartmentId
        {
            get
            {
                return _DepartmentId;
            }
            set
            {
                OnDepartmentIdChanging(value);
                ReportPropertyChanging("DepartmentId");
                _DepartmentId = StructuralObject.SetValidValue(value, "DepartmentId");
                ReportPropertyChanged("DepartmentId");
                OnDepartmentIdChanged();
            }
        }
        private global::System.Int32 _DepartmentId;
        partial void OnDepartmentIdChanging(global::System.Int32 value);
        partial void OnDepartmentIdChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EmployeeModel", "DepartmentEmployee", "Department")]
        public Department Department
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Department>("EmployeeModel.DepartmentEmployee", "Department").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Department>("EmployeeModel.DepartmentEmployee", "Department").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Department> DepartmentReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Department>("EmployeeModel.DepartmentEmployee", "Department");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Department>("EmployeeModel.DepartmentEmployee", "Department", value);
                }
            }
        }

        #endregion

    }

    #endregion

}
