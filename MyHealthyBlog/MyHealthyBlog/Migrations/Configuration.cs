using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MyHealthyBlog.Models;

namespace MyHealthyBlog.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyHealthyBlog.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "MyHealthyBlog.Models.ApplicationDbContext";
        }

        protected override void Seed(MyHealthyBlog.Models.ApplicationDbContext context)
        {
                       if (! context.Users.Any())
            {
                // If the database is empty, populate sample data in it

                CreateUser(context, "admin@gmail.com", "123", "System Administrator");
                CreateUser(context, "pesho@gmail.com", "123", "Peter Ivanov");
                CreateUser(context, "merry@gmail.com", "123", "Maria Petrova");

                CreateRole(context, "Administrators");
                AddUserToRole(context, "admin@gmail.com", "Administrators");

                CreatePost(context,
                    title: "��������������",
                    body: @"<p>������� ����� �� ������ �������� �� ������ ��������� � ������� �� ������� � ���-����� �� �������� ����� �� �������� �� ��� ��������� �� ������ ��������. �������� ��- ����� ����������� � ����������� �� ���������� ���������. ���-����� ����������� ���� ����� ����� ���������� �� �������� �� ������ ������� ���������, �� ������� � �������� � ��������. ���������� � ��������� �����������, �������� � ������������� �� �G.D. Searle� ���� 1965. �������� ����������� � ������������� �� ��������������� �������� �������� </p>
                    <p>���� ��������� �� ������������� ��������� �� ������� � ����������� ���� 1974 ��� ���������� ������� �� ������� � ������������ ���������, ���� �� ������������ ������������ �����. ������� ���� ��������������� ������ �G.D. Searle� ���� ���������� �� ���� �� �����������, ������ </p>
                    ",
                    date: new DateTime(2016, 03, 27, 17, 53, 48),
                    authorUsername: "merry@gmail.com"
                );

                CreatePost(context,
                    title: "����������� �� �������",
                    body: @"<p>�������� �� ������������ �� �������� ���������. ���������� �� ��� ��������� �� ������� � ����� ���������� �� ���������� � ��� �� ����� ����������� � ������ � �� ��� �� �� ��������� ��� ���������� ������� �� ������. �������� �� ��������� ��������� �� ����������� �� ������� �� ���������, �� ���������������� �� ��������, �������� � ��������, ������ �-� ������ �����, ����� � ������ � ��������� �����������, �� ������ �������� �����. ������������ ����� ������ �� ������������� �� ����������������� ������ �� ������ �������������. �������� ����� ���� ���� � ����� �� ������, ��� ���� �� ��������� �� ��������� �������� �������, �������� ���������� ����� � ��� ��-����� ������ ������� � ���������.</p>
                    <p>��� ����� ����������� �� ������� (��� 10�C) �������� �� ������������. ������ ���� � ����� ������� � ��������� ����� �� �� �� ���������� ��������, � �� �������� �� ������ �����������. ��� ��������� ��� 40�C ������������� �� �������� ������� �� ��������, � ��� 70�C ���������� �� ������� ������. ������ � ��������� ������� ������������ �����, �� �� ���� �� �� ���������� �������� � ���������.</p>",
                    date: new DateTime(2016, 05, 11, 08, 22, 03),
                    authorUsername: "merry@gmail.com"
                );

                CreatePost(context,
                    title: "������������ �� ������������ � ������� � ���������",
                    body: @"<p>�������������� � ���� ��������� ���� � ����� ��������, ���� �� ������ ������� �� ���������� ����� ��� �������� ���������. ��� ����� ������ �� ��������� ���� ����������� ��-���� ������������.
�  ����������� �� �� ���������� ��� ���������, ��-����� �� ���������� ��������, � ����� ������ �� ��������� �� ��������� �� ������ �����, ����� �� ����� ���� � ������������ ��������. ��������� �� ����� �������� � ������������; ����� ��� ��� � ��������� �����, ���� � ��������� ��������, �� ��� ����������� ���� � �� ����� �� ������� �� �������������� ���������.</p>
                    <p> ���������  � � ������ ����� ���� �� ������������������� ������� (���) � �� �� � ������������� ���������� �� ���������� �������� ��� ������������� (�������������, ������� ���������). ����� �� �� �� ��������, �������������� ��� ���������� �������� (���. �������������, �������� � ��������). ���������� � ����� ���� �� ������� � ��� ��������� ������, ����� �� �������� � �.���. ��������������� �������� ������� ���������� �� �������� ��������� � � ������ ����������, �� ��� ��������� �������. ��� ���������� ������� ����� ��������� ����� �� �� ����� ���� �� ���������� ��������, ������ �� ����� �� ��������. ������������, ��� ���������� �� ��� ������ ���� � ���������� ������������ ������������! ����� � ���������� �� ����� ���������� �� ���������� �� �������, ����� �� ������� � ������������ ����������������.</p>
                    ",
                    date: new DateTime(2016, 03, 27, 17, 53, 48),
                    authorUsername: "merry@gmail.com"
                );

                CreatePost(context,
                    title: "Rogue Wave Updates Zend Framework",
                    body: @"<p>Rogue Wave is updating its open-source framework for developing Web applications and services. According to the company, this is the first major release in four years. Zend Framework 3 features support for PHP 7, middleware runtime and performance enhancements.</p>
                    <p>The newly released support for PHP 7 aims to simplify how developers create, debug, monitor and deploy modern Web and mobile apps in PHP 7. �This is an exciting time to be a PHP developer,� said Zeev Suraski, cofounder of Zend and CTO of Rogue Wave. �With Zend Framework 3, we�re continuing our quest to make creating PHP applications simpler, more accessible and faster.�</p>
                    <p>In addition, version 3 of the framework features an architectural structure that allows developers to use components within Zend Framework apps or any other framework in order to reduce dependencies, and to enable reuse within the PHP ecosystem.</p>
                    <p>Another key update to the solution is a new middleware runtime. Expressive is designed to focus on simplicity and interoperability, and it enables developers to customize their solutions.</p>
                    ",
                    date: new DateTime(2016, 06, 30, 17, 36, 52),
                    authorUsername: "merry@gmail.com"
                );
                
                context.SaveChanges();
            }
        }

        private void CreateUser(ApplicationDbContext context,
            string email, string password, string fullName)
        {
            var userManager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));
            userManager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 1,
                RequireNonLetterOrDigit = false,
                RequireDigit = false,
                RequireLowercase = false,
                RequireUppercase = false,
            };

            var user = new ApplicationUser
            {
                UserName = email,
                Email = email,
                FullName = fullName
            };

            var userCreateResult = userManager.Create(user, password);
            if (!userCreateResult.Succeeded)
            {
                throw new Exception(string.Join("; ", userCreateResult.Errors));
            }
        }

        private void CreateRole(ApplicationDbContext context, string roleName)
        {
            var roleManager = new RoleManager<IdentityRole>(
                new RoleStore<IdentityRole>(context));
            var roleCreateResult = roleManager.Create(new IdentityRole(roleName));
            if (!roleCreateResult.Succeeded)
            {
                throw new Exception(string.Join("; ", roleCreateResult.Errors));
            }
        }

        private void AddUserToRole(ApplicationDbContext context, string userName, string roleName)
        {
            var user = context.Users.First(u => u.UserName == userName);
            var userManager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));
            var addAdminRoleResult = userManager.AddToRole(user.Id, roleName);
            if (!addAdminRoleResult.Succeeded)
            {
                throw new Exception(string.Join("; ", addAdminRoleResult.Errors));
            }
        }

        private void CreatePost(ApplicationDbContext context,
            string title, string body, DateTime date, string authorUsername)
        {
            var post = new Post();
            post.Title = title;
            post.Body = body;
            post.Date = date;
            post.Author = context.Users.Where(u => u.UserName == authorUsername).FirstOrDefault();
            context.Posts.Add(post);
        }
    }
}

    

