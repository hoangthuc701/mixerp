// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IGetReceiptViewRepository
    {

        int UserId { get; set; }
        int OfficeId { get; set; }
        DateTime DateFrom { get; set; }
        DateTime DateTo { get; set; }
        string Office { get; set; }
        string Party { get; set; }
        string User { get; set; }
        string ReferenceNumber { get; set; }
        string StatementReference { get; set; }

        /// <summary>
        /// Prepares and executes IGetReceiptViewRepository.
        /// </summary>
        IEnumerable<DbGetReceiptViewResult> Execute();
    }
}