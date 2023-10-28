using DocFlow.Domain.Documents;
using DocFlow.Domain.Documents.Cost;
using DocFlow.Domain.Documents.Export;
using DocFlow.Domain.Users;
using DocFlow.Infrastructure.Exporters;
using DocFlow.Infrastructure.Repo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Text;

namespace DocFlow.Application.Services
{
  public class FlowProcess
  {
    private IDocumentRepository _documentRepository = new FakeDocumentRepository();

    private IUserRepository userRepo = new FakeUserRepository();
    private CostCalculatorFactory _costCalculatorFactory = new CostCalculatorFactory(new ConfigurationData());
    private IExporter _exporter;

    public FlowProcess(IExporter exporter)
    {
      _exporter = exporter;
    }

    public DocumentNumber CreateDocument(Guid creatorId, DocumentType type, string title)
    {
      User creator = userRepo.Load(creatorId);

      Document document = DocumentFactory.Create(type, creator);
      document.ChangeTitle(title);

      _documentRepository.Save(document);
      return document.Number;
    }

    public void VerifyDocument(Guid verifierId, DocumentNumber documentNumber)
    {
      Document document = _documentRepository.Load(documentNumber);
      User verifier = userRepo.Load(verifierId);

      document.Verify(verifier);

      _documentRepository.Save(document);
    }

    public void PublishDocument(DocumentNumber documentNumber)
    {
      Document document = _documentRepository.Load(documentNumber);

      document.Publish(_costCalculatorFactory.Create());

      _documentRepository.Save(document);

      //print
      //notify
      //...
    }

    public Stream Export(string number)
    {
      Document doc = _documentRepository.Load(new DocumentNumber(number));

      doc.Export(_exporter);

      Stream result = _exporter.GetResult();

      return result;
    }
  }
}