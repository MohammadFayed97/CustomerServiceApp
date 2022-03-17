global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Identity;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.IdentityModel.Tokens;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;

global using System.Text;
global using System.Security.Claims;
global using System.IdentityModel.Tokens.Jwt;

global using AppSquare.Shared.Server;
global using AppSquare.Shared.AssemplyScanning;

global using Account.Server.Entities;
global using Account.Server.Repositories;
global using AppSquare.Shared.ViewModels;
global using Account.Shared.Validations;
global using FluentValidation;
global using System.Security.Cryptography;
global using Account.Server.TokenServices;
