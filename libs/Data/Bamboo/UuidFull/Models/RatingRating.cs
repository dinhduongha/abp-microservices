using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class RatingRating
{
    public Guid Id { get; set; }

    public Guid? ResModelId { get; set; }

    public Guid? ResId { get; set; }

    public Guid? ParentResModelId { get; set; }

    public Guid? ParentResId { get; set; }

    public Guid? RatedPartnerId { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? MessageId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? ResName { get; set; }

    public string? ResModel { get; set; }

    public string? ParentResName { get; set; }

    public string? ParentResModel { get; set; }

    public string? RatingText { get; set; }

    public string? AccessToken { get; set; }

    public string? Feedback { get; set; }

    public bool? IsInternal { get; set; }

    public bool? Consumed { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? Rating { get; set; }

    public Guid? PublisherId { get; set; }

    public string? PublisherComment { get; set; }

    public DateTime? PublisherDatetime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailMessage? Message { get; set; }

    public virtual IrModel? ParentResModelNavigation { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ResPartner? Publisher { get; set; }

    public virtual ResPartner? RatedPartner { get; set; }

    public virtual IrModel? ResModelNavigation { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
