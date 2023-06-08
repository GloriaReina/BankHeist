public class Teammate{
    public string Name {get; set;}
    public int SkillLevel {get; set;}
    public double CourageFactor {get; set;}

//Create a constructor method to set value of properties when a teammate object is instantiated
public Teammate(string nameInput, int skillLevelInput, double courageFactorInput){
    Name = nameInput;
    SkillLevel = skillLevelInput;
    CourageFactor = courageFactorInput;
    }
}