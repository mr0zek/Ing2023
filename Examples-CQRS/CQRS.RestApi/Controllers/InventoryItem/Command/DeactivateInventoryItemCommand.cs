﻿using System;
using CQRS.Application.Contract;
using CQRS.RestApi.Concurrency;

namespace CQRS.RestApi.Controllers.InventoryItem.Command
{
  public class DeactivateInventoryItemCommand : IConcurrencyAware, IDeactivateInventoryItemCommand
  {
    public Guid Id { get; set; }
    public string ConcurrencyVersion { get; set; }
    public Guid InventoryItemId => Id;

    public int? OriginalVersion => int.TryParse(ConcurrencyVersion, out var versionNumber) ? (int?) versionNumber : null;
  }
}