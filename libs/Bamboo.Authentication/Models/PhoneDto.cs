using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;
public class OtpDto
{
    public string Phone { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public string Desc { get; set; } = string.Empty;
    public DateTimeOffset? CreationDate { get; set; }
}