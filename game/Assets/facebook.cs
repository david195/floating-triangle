using UnityEngine;
using System.Collections;

public class facebook : MonoBehaviour {

	const string appId="293831670802453";
	const string fbUrl="http://www.facebook.com/dialog/feed"; 
	
	public void share(string link,string pictureLink,string name,string caption,string  description,string redirect) 
	{
		Application.OpenURL(fbUrl +
		                    "?app_id="+appId 
		                    +"&link="+WWW.EscapeURL(link) 
		                    +"&picture="+WWW.EscapeURL(pictureLink)
		                    +"&name="+WWW.EscapeURL(name)
		                    +"&caption="+WWW.EscapeURL(caption)
		                    +"&description="+WWW.EscapeURL(description)
		                    +"&redirect_uri="+redirect); 
	}
}
