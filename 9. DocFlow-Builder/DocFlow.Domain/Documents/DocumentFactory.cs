using DocFlow.Domain.Documents.Numbers;
using DocFlow.Domain.Documents.Validation.chain;
using DocFlow.Domain.Users;
using System;

namespace DocFlow.Domain.Documents
{
  public class DocumentFactory //: IDocumentFactory
  {
    public static Document Create(DocumentType type, User author)
    {
      var generator = NumberGeneratorFactory.Create(new ConfigurationData());
      return new Document(type, author, generator.Generate(), new ManagerDocumentValidator());
    }
  }
}