public class Calc                                                                                                               
{                                                                                                                               
   const double fG=1;                                                                                                           
   const double kG=1;                                                                                                           
                                                                                                                                
   const double KX=1;                                                                                                           
   const double KY=1;                                                                                                           
   const double KZ=1;                                                                                                           
   const double KR=1;                                                                                                           
   const double KP=1;                                                                                                           
                                                                                                                                
   static public double Rv=0;                                                                                                   
   static public double Lv=0;                                                                                                   
   static public double MAXIMO=22;                                                                                                   
   
   static public double CalcRightActuator(double R, double P,double X, double Y,double Z)                                       
   {                                                                                                                            
      X=X*KX;                                                                                                                   
      Y=Y*KY;                                                                                                                   
      Z=Z*KZ;                                                                                                                   
      R=R*KR;                                                                                                                   
      P=P*KP;                                                                                                                   
                                                                                                                                
                                                                                                                                
      Rv+=((R + P + X + Y + Z )-Rv)/fG;                                                                                         
      if (Rv > MAXIMO) {
		  return (MAXIMO*kG*-1);
	  }
	  if (Rv < (MAXIMO*-1)) {
		  return (MAXIMO*kG);
	  }
      return (Rv*kG*-1);                                                                                                          
   }                                                                                                                            
                                                                                                                                
   static public double CalcLeftActuator(double R, double P,double X, double Y,double Z)                                        
   {                                                                                                                            
      X=X*KX;                                                                                                                   
      Y=Y*KY;                                                                                                                   
      Z=Z*KZ;                                                                                                                   
      R=R*KR;                                                                                                                   
      P=P*KP;                                                                                                                   
                                                                                                                                
                                                                                                                                
      Lv+=((-R + P - X + Y + Z )-Lv)/fG;                                                                                        
                                                                                                                                
      if (Lv > MAXIMO) {
		  return (MAXIMO*kG);
	  }
	  if (Lv < (MAXIMO*-1)) {
		  return (MAXIMO*kG*-1);
	  }
      return (Lv*kG);                                                                                                          
                                                                                                                                
   }                                                                                                                            
}                                                                                                                               
                                                                                                                                
                                                                                                                                
