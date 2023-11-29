using SingleResponsability;

StudentRepository studentRepository = new();
ExporterHelperCSV exporterHelper = new();
exporterHelper.ExportStudents(studentRepository.GetAll());
Console.WriteLine("Proceso Completado");