const string foldername = "FileCollection";
const string filename = "Results.txt";

long XLSCount = 0 , DOCCount= 0, pptCount =0;
long XLSSize = 0, DOCSize =0 , PPTsize =0 ;
long totalFiles = 0;
long totalSize =0;

bool isOfficeFIle(string filename){
    if(filename.EndsWith(".docx")|| filename.EndsWith(".pptx") || filename.EndsWith(".xlsx")){
        return true;
    }
    return false;
}

DirectoryInfo di = new DirectoryInfo(foldername);

foreach (FileInfo fi in di.EnumerateFiles()){
    if(isOfficeFIle(fi.Name)){
        totalFiles++;
        totalSize+=fi.Length;
        if(fi.Name.EndsWith(".docx")){
            DOCCount++;
            DOCSize += fi.Length;
        }
        else if(fi.Name.EndsWith(".xlsx")){
            XLSCount++;
            XLSSize += fi.Length;
        }
        else if(fi.Name.EndsWith(".pptx")){
            pptCount++;
            PPTsize += fi.Length;
        }
    }
}
// Output result

using( StreamWriter sw = File.CreateText(filename)){
    sw.WriteLine("~~~~~~~~Results~~~~~~~");
    sw.WriteLine(($"Total Files: {totalFiles}"));
    sw.WriteLine(($"Total Size: {totalSize}"));
    sw.WriteLine(($"Excel Files: {XLSCount}"));
    sw.WriteLine(($"Excel Files Size: {XLSSize}"));
    sw.WriteLine(($"Doc Files: {DOCCount}"));
    sw.WriteLine(($"Doc Files Size: {DOCSize}"));
    sw.WriteLine(($"Ppt Files: {pptCount}"));
    sw.WriteLine(($"Ppt Files Size: {PPTsize}"));
    
}