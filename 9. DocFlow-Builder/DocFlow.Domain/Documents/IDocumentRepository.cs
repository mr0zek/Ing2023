using System;
using System.Collections.Generic;

namespace DocFlow.Domain.Documents
{
  public interface IDocumentRepository
  {
    void Save(Document document);

    Document Load(DocumentNumber number);

    Document Load(Guid id);

    IEnumerable<Document> GetAll();
  }
}