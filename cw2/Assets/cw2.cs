using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int heroHeight = 188;
        int heroAge = 16;
        string heroName = "dablo";
        string heroSuperpower = "super speed";


        

        int vililanHeight = 178;
        int vililanAge = 21;
        string vililanName = "mark";
        string vililanSuperpower ="ice power";


        int ageDifference = (vililanAge - heroAge);
        




        print ("there ageDifference is "+ageDifference);
        print ("my neme is "+heroName+" and i am here to save the day");
        print ("oh no it "+vililanName+" he is here to steal from the bank");
        print (heroName+"'s age if you add 5 years is "+(heroAge+5));
        print ("there superpowers are "+vililanSuperpower+" and "+heroSuperpower);
        print (heroName+" is "+heroAge+" years old while "+vililanName+" is "+vililanAge+"years old");
        print (heroName+" is "+heroHeight+"cm tall wihle "+vililanName+" is "+vililanHeight+"cm tall");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
