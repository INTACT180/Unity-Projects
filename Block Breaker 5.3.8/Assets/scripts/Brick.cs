using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public static int bricksThisLevel = 0;
	public Sprite[] hitSprites;
	public AudioClip crack;
	
	private int timesHit;
	private LevelManager levelManager;
	
	
	// Use this for initialization
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		timesHit = 0;
		
		bool isBreakable = (this.tag == "Breakable");
		print (isBreakable.ToString());
		if(isBreakable)
			bricksThisLevel++;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	
	void OnCollisionEnter2D(Collision2D collision)
	{
		bool isBreakable = (this.tag == "Breakable");
		if(isBreakable)
			HandleHits();
	}
	
	void HandleHits()
	{
		timesHit++;
		AudioSource.PlayClipAtPoint(crack,this.transform.position);
		
		if(timesHit >= hitSprites.Length){
			--bricksThisLevel;
			levelManager.BrickDestroyed();
			Destroy(gameObject);
		}
		else{
			LoadSprites();
		}
	}
	
	void LoadSprites()
	{
		int spriteIndex = timesHit;
		
		if(hitSprites[spriteIndex])
			this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
	}
}
