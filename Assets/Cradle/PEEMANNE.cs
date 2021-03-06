/*
------------------------------------------------
Generated by Cradle 2.0.1.0
https://github.com/daterre/Cradle

Original file: PEEMANNE.html
Story format: Harlowe
------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using IStoryThread = System.Collections.Generic.IEnumerable<Cradle.StoryOutput>;
using Cradle.StoryFormats.Harlowe;

public partial class @PEEMANNE: Cradle.StoryFormats.Harlowe.HarloweStory
{
	#region Variables
	// ---------------

	public class VarDefs: RuntimeVars
	{
		public VarDefs()
		{
			VarDef("one", () => this.@one, val => this.@one = val);
			VarDef("two", () => this.@two, val => this.@two = val);
			VarDef("three", () => this.@three, val => this.@three = val);
			VarDef("computeron", () => this.@computeron, val => this.@computeron = val);
		}

		public StoryVar @one;
		public StoryVar @two;
		public StoryVar @three;
		public StoryVar @computeron;
	}

	public new VarDefs Vars
	{
		get { return (VarDefs) base.Vars; }
	}

	// ---------------
	#endregion

	#region Initialization
	// ---------------

	public readonly Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros macros1;

	@PEEMANNE()
	{
		this.StartPassage = "Room";

		base.Vars = new VarDefs() { Story = this, StrictMode = true };

		macros1 = new Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros() { Story = this };

		base.Init();
		passage1_Init();
		passage2_Init();
		passage3_Init();
		passage4_Init();
		passage5_Init();
		passage6_Init();
		passage7_Init();
		passage8_Init();
		passage9_Init();
		passage10_Init();
		passage11_Init();
		passage12_Init();
		passage13_Init();
	}

	// ---------------
	#endregion

	// .............
	// #1: Room

	void passage1_Init()
	{
		this.Passages[@"Room"] = new StoryPassage(@"Room", new string[]{  }, passage1_Main);
	}

	IStoryThread passage1_Main()
	{
		yield return text("You are standing in your mancave. The floors are filled with trash and the walls filled with anime posters. The slight breeze of the ceiling fan distributes the smell of several months old spaghetti dinner around the whole apartment beautifully.");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Check the Refrigerator", "CheckRefrigerator", null);
		yield return lineBreak();
		yield return link("Check your Apartment Door", "CheckDoor", null);
		yield return lineBreak();
		yield return link("Turn on the Computer", "CheckComputer", null);
		yield return lineBreak();
		yield return lineBreak();
		if((Vars.one == true) && (Vars.two == true) && (Vars.three == true)) {
			yield return lineBreak();
			yield return text("It's time.");
			yield return lineBreak();
			yield return link("Turn on the Sink", "TurnOnSink", null);
		}
		yield break;
	}


	// .............
	// #2: CheckComputer

	void passage2_Init()
	{
		this.Passages[@"CheckComputer"] = new StoryPassage(@"CheckComputer", new string[]{  }, passage2_Main);
	}

	IStoryThread passage2_Main()
	{
		yield return text("As you press the button, the glow of your decades old CRT-monitor slowly fades in to burn your eyes. The fan is spinning so fast that you feel like the computer could explode at any moment");
		yield return lineBreak();
		Vars.computeron  = true;
		yield return lineBreak();
		yield return text("You see your ");
		yield return link("beautiful desktop", "Desktop", null);
		yield return text(" infront of you.");
		yield break;
	}


	// .............
	// #3: CheckRefrigerator

	void passage3_Init()
	{
		this.Passages[@"CheckRefrigerator"] = new StoryPassage(@"CheckRefrigerator", new string[]{  }, passage3_Main);
	}

	IStoryThread passage3_Main()
	{
		yield return text("As soon as you open the door, the strong smell of expired Gamerfuel and molded bread fills the house. You drink as much as you can until you feel properly fueled up.");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Back", "Room", null);
		yield break;
	}


	// .............
	// #4: TurnOnSink

	void passage4_Init()
	{
		this.Passages[@"TurnOnSink"] = new StoryPassage(@"TurnOnSink", new string[]{  }, passage4_Main);
	}

	IStoryThread passage4_Main()
	{
		yield return text("You turn on the sink, a black fluid that is most definitely not water pours out");
		yield return lineBreak();
		yield return link("Bottoms up my dudes", "DrinkJuice", null);
		yield break;
	}


	// .............
	// #5: CheckDoor

	void passage5_Init()
	{
		this.Passages[@"CheckDoor"] = new StoryPassage(@"CheckDoor", new string[]{  }, passage5_Main);
	}

	IStoryThread passage5_Main()
	{
		yield return text("outside stinks.");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Go back", "Room", null);
		yield break;
	}


	// .............
	// #6: OpenNetscapeNavigator

	void passage6_Init()
	{
		this.Passages[@"OpenNetscapeNavigator"] = new StoryPassage(@"OpenNetscapeNavigator", new string[]{  }, passage6_Main);
	}

	IStoryThread passage6_Main()
	{
		yield return text("You open up your internet browser, the infinite wonders of the information superhighway seem indimitading, yet welcoming.");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Go to PissGaming.net", "PissNet", null);
		yield return lineBreak();
		yield return link("Click the Ad that says \"Single Mothers Nearby Who Want Fuck\" ", "Ad", null);
		yield return lineBreak();
		yield return link("Fuck it", "Desktop", null);
		yield break;
	}


	// .............
	// #7: DrawInPaint

	void passage7_Init()
	{
		this.Passages[@"DrawInPaint"] = new StoryPassage(@"DrawInPaint", new string[]{  }, passage7_Main);
	}

	IStoryThread passage7_Main()
	{
		yield return text("You open up MSPaint, the latest innovation in the field of painting, your mind wonders with endless artistic possibilities.");
		yield return lineBreak();
		yield return text("You end up drawing a penis and ");
		yield return link("closing the program.", "Desktop", null);
		yield break;
	}


	// .............
	// #8: DrinkJuice

	void passage8_Init()
	{
		this.Passages[@"DrinkJuice"] = new StoryPassage(@"DrinkJuice", new string[]{  }, passage8_Main);
	}

	IStoryThread passage8_Main()
	{
		yield return text("Incredible power is resurging within you...");
		yield return lineBreak();
		yield return text("oh wait no your lungs clog up and suffocated to death.");
		yield return lineBreak();
		using (Group("strong", true)) {
				using (Group("em", true)) {
				yield return text("Wow!");
			}
		}
		yield return text(" That sure was a horrible idea! stupid ass");
		yield return lineBreak();
		yield return lineBreak();
		yield return lineBreak();
		yield return text("001");
		yield return lineBreak();
		yield return text("304");
		yield return lineBreak();
		yield return text("200");
		yield break;
	}


	// .............
	// #9: Ad

	void passage9_Init()
	{
		this.Passages[@"Ad"] = new StoryPassage(@"Ad", new string[]{  }, passage9_Main);
	}

	IStoryThread passage9_Main()
	{
		yield return text("The moms you were promised turned out to be a lie as there were only single dads in there. ");
		Vars.one  = true;
		yield return lineBreak();
		yield return text("You sigh and ");
		yield return link("press the back button.", "OpenNetscapeNavigator", null);
		yield break;
	}


	// .............
	// #10: Desktop

	void passage10_Init()
	{
		this.Passages[@"Desktop"] = new StoryPassage(@"Desktop", new string[]{  }, passage10_Main);
	}

	IStoryThread passage10_Main()
	{
		yield return text("You stare intently at your beautiful desktop and an intense sense of euphoria rushes over you as you think to yourself; ");
		using (Group("em", true)) {
			yield return text("\"This is it, gamer's paradise.\"");
		}
		yield return lineBreak();
		yield return lineBreak();
		yield return link("*Surf* the *Net*", "OpenNetscapeNavigator", null);
		yield return text(" ");
		yield return lineBreak();
		yield return link("Practice Fine Arts", "DrawInPaint", null);
		yield return text(" ");
		yield return lineBreak();
		yield return link("GAMER MODE: ON", "GamingTime", null);
		yield return lineBreak();
		yield return link("Turn Off Computer", "Room", null);
		yield return text(" ");
		yield break;
	}


	// .............
	// #11: GamingTime

	void passage11_Init()
	{
		this.Passages[@"GamingTime"] = new StoryPassage(@"GamingTime", new string[]{  }, passage11_Main);
	}

	IStoryThread passage11_Main()
	{
		yield return htmlTag("<img src=\"ready2game.png\"/>");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("You put on your Gaming Glasses™ and Gaming Gloves™ but not before covering your entire body in Gaming Goo™.");
		yield return lineBreak();
		yield return text("You boot up your favorite game ");
		using (Group("em", true)) {
			yield return text("Senku Tetsura Enternity: Vampire Rebellion 95; Battle for Third Neo Detroit \"The Quantum Armageddon\" (大きな悪臭)");
		}
		yield return text(" and get ready to pwn some noobs online.");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Get killed immediately by a sniper, write an angry message into the chat", "upsetti", null);
		yield break;
	}


	// .............
	// #12: PissNet

	void passage12_Init()
	{
		this.Passages[@"PissNet"] = new StoryPassage(@"PissNet", new string[]{  }, passage12_Main);
	}

	IStoryThread passage12_Main()
	{
		yield return text("The website seems familiar yet distant somehow.");
		yield return lineBreak();
		yield return text("There is a logo with a picture of a planet and next to it words \"pissNET\"");
		yield return lineBreak();
		yield return text("There are 5 panels; News, Forums, Video Games, Sports and Live Chat.");
		yield return lineBreak();
		yield return link("You decide not to click on any of them.", "OpenNetscapeNavigator", null);
		yield return text(" ");
		yield return lineBreak();
		Vars.three  = true;
		yield break;
	}


	// .............
	// #13: upsetti

	void passage13_Init()
	{
		this.Passages[@"upsetti"] = new StoryPassage(@"upsetti", new string[]{  }, passage13_Main);
	}

	IStoryThread passage13_Main()
	{
		yield return text("You write a long and descriptive message about how you had sexual intercourse with the opposing player's mother. Before you're able to send the message however you notice that the game ended 30 minutes ago.");
		yield return lineBreak();
		Vars.two  = true;
		yield return lineBreak();
		yield return lineBreak();
		yield return link("ALT+F4", "Desktop", null);
		yield return text(" ");
		yield break;
	}


}