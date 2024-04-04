// See https://aka.ms/new-console-template for more information
using LoadTest;
using System.Diagnostics;
using System.Text;

var numerOfRecords = 50000;

// Generate sample data
var records1 = GenerateSampleData(numerOfRecords);
RunLoadTestSB(records1);

var records2 = GenerateSampleData(numerOfRecords);
var sb = new StringBuilder();
RunLoadTestSBAsInput(records2);

var records3 = GenerateSampleData(numerOfRecords);
RunLoadTestSwitchCase(records3);

var records4 = GenerateSampleData(numerOfRecords);
RunLoadTestReplace(records4);

// Process each record


static void RunLoadTestSB(Message_SR_12_2_ESME[] records)
{
    Console.ForegroundColor= ConsoleColor.Green;
    Console.WriteLine("String Builder");
    Console.ResetColor();


    long memoryBefore = GC.GetTotalMemory(true);
    Stopwatch stopwatch = Stopwatch.StartNew();
    foreach (var record in records)
    {
        StringReplace.ESMEVariantMappingSB(record);
    }
    stopwatch.Stop();

    // Measure memory usage after processing
    long memoryAfter = GC.GetTotalMemory(false);


    Console.WriteLine($"Total memory used: {(memoryAfter - memoryBefore) / 1024} KB");
    Console.WriteLine($"Total execution time: {stopwatch.ElapsedMilliseconds} milliseconds");
}

static void RunLoadTestSBAsInput(Message_SR_12_2_ESME[] records)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("String Builder as parameter");
    Console.ResetColor();

    long memoryBefore = GC.GetTotalMemory(true);
    Stopwatch stopwatch = Stopwatch.StartNew();
    foreach (var record in records)
    {
        StringReplace.ESMEVariantMappingSB(record, new StringBuilder(record.ESMEVariant, record.ESMEVariant!.Length*2));
    }
    stopwatch.Stop();

    // Measure memory usage after processing
    long memoryAfter = GC.GetTotalMemory(false);

    Console.WriteLine($"Total memory used: {(memoryAfter - memoryBefore) / 1024} KB");
    Console.WriteLine($"Total execution time: {stopwatch.ElapsedMilliseconds} milliseconds");
}

static void RunLoadTestSwitchCase(Message_SR_12_2_ESME[] records)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Switch case");
    Console.ResetColor();


    long memoryBefore = GC.GetTotalMemory(true);
    Stopwatch stopwatch = Stopwatch.StartNew();
    foreach (var record in records)
    {
        StringReplace.ESMEVariantMappingSwitchCase(record);
    }
    stopwatch.Stop();

    // Measure memory usage after processing
    long memoryAfter = GC.GetTotalMemory(false);


    Console.WriteLine($"Total memory used: {(memoryAfter - memoryBefore) / 1024} KB");
    Console.WriteLine($"Total execution time: {stopwatch.ElapsedMilliseconds} milliseconds");
}


static void RunLoadTestReplace(Message_SR_12_2_ESME[] records)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("String.Replace");
    Console.ResetColor();


    long memoryBefore = GC.GetTotalMemory(true);
    Stopwatch stopwatch = Stopwatch.StartNew();
    foreach (var record in records)
    {
        StringReplace.ESMEVariantMappingReplace(record);
    }
    stopwatch.Stop();

    // Measure memory usage after processing
    long memoryAfter = GC.GetTotalMemory(false);

    Console.WriteLine($"Total memory used: {(memoryAfter - memoryBefore) / 1024} KB");
    Console.WriteLine($"Total execution time: {stopwatch.ElapsedMilliseconds} milliseconds");
}
static Message_SR_12_2_ESME[] GenerateSampleData(int count)
{
    Random random = new Random();
    Message_SR_12_2_ESME[] records = new Message_SR_12_2_ESME[count];
    for (int i = 0; i < count; i++)
    {
        int randomIndex = random.Next(0, 9); // Random index between 0 and 8
        string randomESMEVariant = GetRandomESMEVariant(randomIndex);
        records[i] = new Message_SR_12_2_ESME { ESMEVariant = randomESMEVariant };
    }
    return records;
}

static string GetRandomESMEVariant(int index)
{
    switch (index)
    {
        case 0: return ESMEVariantDuis.A;
        case 1: return ESMEVariantDuis.B;
        case 2: return ESMEVariantDuis.C;
        case 3: return ESMEVariantDuis.AD;
        case 4: return ESMEVariantDuis.BD;
        case 5: return ESMEVariantDuis.CD;
        case 6: return ESMEVariantDuis.ADE;
        case 7: return ESMEVariantDuis.BDE;
        case 8: return ESMEVariantDuis.CDE;
        default: return ESMEVariantDuis.A; // Default to A if index is out of range
    }
}
