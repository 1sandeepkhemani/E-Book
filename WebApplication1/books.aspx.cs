using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class books : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uname"] != null)
            {
               Label1.Text = Session["uname"].ToString();
            }

            else
            {
                
                Response.Redirect("WebForm3.aspx");
            }

            Label2.Text = " Top Books";
            Image2.ImageUrl = "~/Scripts/WebForms/img2.jpeg";
            Label3.Text = " E-Books Store is a remarkable eBook libary to free download the books of your choice. Among the top free eBook sites available you can access on the \r\n                     internet, you should undoubtedly try out E-Books Store. The site is one of the most extensive online book libaries with countless eBooks in various \r\n                     categories. You can choose from mystery, horror, thriller, adventure and much more. Using a free sign-up on the website, you can download eBooks in PDF \r\n                     and other supported formats on E-Books Store easily.";


            Image3.ImageUrl = "~/bookimagecover/ends-with.jpeg";
            Label4.Text = "It Ends With Us";
            Label5.Text = "Colleen Hoover";
            HyperLink1.NavigateUrl = "bookpdf/it-ends-with-us.pdf";
            HyperLink2.NavigateUrl = "bookpdf/it-ends-with-us.pdf";
            Label6.Text = "Colleen Hoover's \"It Ends With Us\" is a complex romance novel that explores themes of domestic violence, first love, and finding your strength. Lily Bloom, the protagonist, is a young woman who has just moved to Boston to start fresh. She's haunted by the memories of her abusive father and finds solace in her work as a florist.\r\n\r\nLily's world is turned upside down when she meets Ryle Kincaid, a handsome and brooding neurosurgeon. Their connection is intense, but Ryle is adamant about not wanting a serious relationship.\r\n\r\nAs Lily delves deeper into her relationship with Ryle, she also begins to revisit her past through her teenage journals.  These journals tell the story of her first love, Atlas Corrigan, a homeless boy she met as a teenager. Atlas became her confidante and protector during a difficult time in her life.";


            Image4.ImageUrl = "~/bookimagecover/the-last-man.jpg";
            Label7.Text = "The Last Man";
            Label8.Text = "Mary Shelley";
            HyperLink3.NavigateUrl = "bookpdf/The-Last-Man.pdf";
            HyperLink4.NavigateUrl = "bookpdf/The-Last-Man.pdf";
            Label9.Text = "\r\nIn Mary Shelley's novel \"The Last Man,\" published in 1826, a mysterious plague sweeps across the globe, relentlessly targeting men. The protagonist, Lionel Verney, witnesses the societal collapse and the suffering around him as women, seemingly immune, struggle to maintain order amidst the chaos. Lionel grapples with isolation, grief for his deceased loved ones, and the existential questions of his own mortality and the future of humanity in a world teetering on the brink of oblivion.";


            Image5.ImageUrl = "~/bookimagecover/the-shining.jpg";
            Label10.Text = "The Shining";
            Label11.Text = "Stephen King";
            HyperLink5.NavigateUrl = "bookpdf/The-Shining.pdf";
            HyperLink6.NavigateUrl = "bookpdf/The-Shining.pdf";
            Label12.Text = "In Stephen King's \"The Shining,\" Jack Torrance, a struggling writer and recovering alcoholic, takes a job as the winter caretaker of the isolated Overlook Hotel. He brings his wife Wendy and son Danny, who possesses a psychic ability called \"the shining.\" During their stay, the grandeur and isolation of the hotel, coupled with its dark history, begin to take their toll on Jack. As winter sets in, the hotel's sinister influence amplifies, manipulating Jack and turning him against his family. Danny, relying on his shining, must fight for their survival against the hotel's evil forces and a deranged Jack.";


            Image6.ImageUrl = "~/bookimagecover/wings.jpg";
            Label13.Text = "Wings of Fire";
            Label14.Text = "A.P.J. Abdul Kalam";
            HyperLink7.NavigateUrl = "bookpdf/wings.pdf";
            HyperLink8.NavigateUrl = "bookpdf/wings.pdf";
            Label15.Text = "Autobiography: The most famous \"Wings of Fire\" is the autobiography of Dr. A. P. J. Abdul Kalam, the former president of India. It details his rise from a humble background to become a leading Indian scientist in the space and missile programs.\r\nFantasy Series: There's also a popular fantasy series for young adults called \"Wings of Fire\" by Tui T. Sutherland. This series follows five young dragons from different tribes who train at a special academy. They face a dark prophecy and must work together to prevent a terrible future.";


            Image7.ImageUrl = "~/bookimagecover/the-silent-patient.jpg";
            Label16.Text = "The Silent Patient";
            Label17.Text = "Alex Michaelides";
            HyperLink9.NavigateUrl = "bookpdf/The Silent Patient Book PDF.pdf";
            HyperLink10.NavigateUrl = "bookpdf/The Silent Patient Book PDF.pdf";
            Label18.Text = "\r\nIn \"The Silent Patient,\" renowned artist Alicia Berenson shoots her husband Gabriel in the face five times, then descends into an unnerving silence. Declared unfit to stand trial, she resides in a secure psychiatric facility, never uttering a word. Enter Theo Faber, a psychotherapist driven to unravel the truth behind her actions. Through therapy sessions and Alicia's own diary entries, Theo delves into the couple's seemingly idyllic life, uncovering hidden tensions, past traumas, and a web of secrets that challenge everything he thought he knew. As Theo becomes increasingly fixated on Alicia and her case, the lines between patient and therapist blur, leading him down a dangerous path towards the shocking truth";


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            
            Response.Redirect("WebForm3.aspx");

        }

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            Label2.Text = "Mystery Books";
            Image2.ImageUrl = "~/Scripts/WebForms/mt.jpg";


            Image3.ImageUrl = "~/bookimagecover/crime-and-punishmentcover.jpeg";
            Label4.Text = "Crime And Punishment";
            Label5.Text = "Fyodor Dostoevsky";
            HyperLink1.NavigateUrl = "bookpdf/crime-and-punishment.pdf";
            HyperLink2.NavigateUrl = "bookpdf/crime-and-punishment.pdf";
            Label6.Text = "In Fyodor Dostoevsky's \"Crime and Punishment,\" we meet Rodion Raskolnikov, a destitute ex-student living in St. Petersburg. Poverty and his own twisted theories lead him to believe he is above the law, and he plots to murder an old pawnbroker. However, the act itself and the accidental killing of an innocent bystander plunge him into a deep psychological crisis. Wracked with guilt and paranoia, Raskolnikov is forced to confront the moral and emotional consequences of his crime, while detective Porfiry Petrovich relentlessly investigates him. The story delves into themes of morality, guilt, redemption, and the complexities of human psychology.";


            Image4.ImageUrl = "~/bookimagecover/the-bottle-imp.jpeg";
            Label7.Text = "The Bottle IMP";
            Label8.Text = "Robert Louis Stevenson";
            HyperLink3.NavigateUrl = "bookpdf/The-Bottle-Imp.pdf";
            HyperLink4.NavigateUrl = "bookpdf/The-Bottle-Imp.pdf";
            Label9.Text = "\r\nIn Robert Louis Stevenson's \"The Bottle Imp,\" Keawe, a poor Hawaiian, purchases a mysterious bottle containing an imp who grants wishes. However, a dark secret lurks within. The imp fulfills desires, but ownership comes at a terrible cost. If Keawe dies with the bottle, his soul is damned to hell. He faces a constant moral dilemma: use the imp's power and risk eternal suffering, or reject its tempting allure and face his earthly struggles. The story explores themes of temptation, the true value of happiness, and the power of love and sacrifice.\r\n\r\n";


            Image5.ImageUrl = "~/bookimagecover/the-dry.jpeg";
            Label10.Text = "The Dry";
            Label11.Text = "Jane Harper";
            HyperLink5.NavigateUrl = "bookpdf/the-dry.pdf";
            HyperLink6.NavigateUrl = "bookpdf/the-dry.pdf";
            Label12.Text = "\r\nIn Jane Harper's novel \"The Dry,\" Detective Aaron Falk returns to his drought-stricken hometown after years away to attend his childhood friend's funeral. The seemingly straightforward suicide quickly takes a turn as Falk uncovers secrets and suspicions hidden beneath the town's surface. As he investigates, he grapples with his own past trauma and the harsh realities of a community struggling with water scarcity and deep-seated resentments. The story unfolds against the backdrop of a relentless drought, adding another layer of tension and highlighting the fragility of the environment and its impact on human lives.";


            Image6.ImageUrl = "~/bookimagecover/the-secret-adversary.jpg";
            Label13.Text = "The Secret Adversary";
            Label14.Text = "Agatha Christie";
            HyperLink7.NavigateUrl = "bookpdf/The-Secret-Adversary.pdf";
            HyperLink8.NavigateUrl = "bookpdf/The-Secret-Adversary.pdf";
            Label15.Text = "\r\nIn post-WWI London, two down-on-their-luck friends, Tommy and Tuppence, start \"The Young Adventurers, Ltd.\" seeking excitement and fortune. Their first client, Mr. Whittington, offers a suspiciously large sum to find Jane Finn, a woman who disappeared on the Lusitania. When Tuppence claims to be Jane, Whittington panics, offering her hush money. Intrigued, Tommy and Tuppence delve deeper, uncovering a web of secrets and a hidden plot that threatens the nation's stability. As they navigate danger and deceit, they must unravel the mystery before it's too late.";


            Image7.ImageUrl = "~/bookimagecover/the-silent-patient.jpg";
            Label16.Text = "The Silent Patient";
            Label17.Text = "Alex Michaelides";
            HyperLink9.NavigateUrl = "bookpdf/The Silent Patient Book PDF.pdf";
            HyperLink10.NavigateUrl = "bookpdf/The Silent Patient Book PDF.pdf";
            Label18.Text = "\r\nIn \"The Silent Patient,\" renowned artist Alicia Berenson shoots her husband Gabriel in the face five times, then descends into an unnerving silence. Declared unfit to stand trial, she resides in a secure psychiatric facility, never uttering a word. Enter Theo Faber, a psychotherapist driven to unravel the truth behind her actions. Through therapy sessions and Alicia's own diary entries, Theo delves into the couple's seemingly idyllic life, uncovering hidden tensions, past traumas, and a web of secrets that challenge everything he thought he knew. As Theo becomes increasingly fixated on Alicia and her case, the lines between patient and therapist blur, leading him down a dangerous path towards the shocking truth";

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Label2.Text = "Thriller Books";
            Image2.ImageUrl = "~/Scripts/WebForms/mt.jpg";


            Image3.ImageUrl = "~/bookimagecover/a-flicker-in-the-dark.jpg";
            Label4.Text = "A Flicker In The Dark";
            Label5.Text = "Stacy Willingham";
            HyperLink1.NavigateUrl = "bookpdf/A Flicker in the Dark.pdf";
            HyperLink2.NavigateUrl = "bookpdf/A Flicker in the Dark.pdf";
            Label6.Text = "In \"A Flicker In The Dark,\" darkness descends not just literally, but also metaphorically. The story follows the investigation into the disappearance of a young woman, Hannah, from a seemingly idyllic small town. As Detective Alex Morrow delves deeper, she uncovers a web of secrets and hidden darkness within the community, forcing her to confront her own inner demons while searching for the truth. The book explores themes of loss, betrayal, and the complexities of human nature, all woven into a suspenseful and gripping narrative.";


            Image4.ImageUrl = "~/bookimagecover/the-last-man.jpg";
            Label7.Text = "The Last Man";
            Label8.Text = "Mary Shelley";
            HyperLink3.NavigateUrl = "bookpdf/The-Last-Man.pdf";
            HyperLink4.NavigateUrl = "bookpdf/The-Last-Man.pdf";
            Label9.Text = "\r\nIn Mary Shelley's novel \"The Last Man,\" published in 1826, a mysterious plague sweeps across the globe, relentlessly targeting men. The protagonist, Lionel Verney, witnesses the societal collapse and the suffering around him as women, seemingly immune, struggle to maintain order amidst the chaos. Lionel grapples with isolation, grief for his deceased loved ones, and the existential questions of his own mortality and the future of humanity in a world teetering on the brink of oblivion.";


            Image5.ImageUrl = "~/bookimagecover/moonstone.jpg";
            Label10.Text = "The Moonstone";
            Label11.Text = "Wilkie Collins";
            HyperLink5.NavigateUrl = "bookpdf/moonstone.pdf";
            HyperLink6.NavigateUrl = "bookpdf/moonstone.pdf";
            Label12.Text = "In Wilkie Collins's \"The Moonstone,\" a young woman named Rachel Verinder inherits a legendary Indian diamond on her eighteenth birthday. This Moonstone, cursed and of immense value, becomes the center of a thrilling mystery. The precious gem, stolen on the very night Rachel receives it, unleashes a chain of events involving suspicious characters, hidden motives, and a relentless pursuit by the rightful Hindu custodians. As Rachel's world is turned upside down, the reader dives into a captivating tale of intrigue, suspicion, and the enduring allure of a cursed jewel.";


            Image6.ImageUrl = "~/bookimagecover/dark-places.jpg";
            Label13.Text = "Dark Places";
            Label14.Text = "Gillian Flynn";
            HyperLink7.NavigateUrl = "bookpdf/Dark-places.pdf";
            HyperLink8.NavigateUrl = "bookpdf/Dark-places.pdf";
            Label15.Text = "Gillian Flynn's \"Dark Places\" follows Libby Day, a woman haunted by a childhood tragedy. Decades ago, her entire family was brutally murdered, and Libby, then a young girl, was the only survivor. Branded as a potential suspect by the media and ostracized by her community, she has built a reclusive life. Years later, a true crime society contacts Libby, claiming they have new information about the case. Drawn by the possibility of finally uncovering the truth, Libby embarks on a journey to revisit the dark places of her past, confronting old traumas and unraveling long-buried secrets as she seeks the truth about the night that changed her life forever.";


            Image7.ImageUrl = "~/bookimagecover/the-guest-list.jpeg";
            Label16.Text = "The Guest List";
            Label17.Text = "Lucy Foley";
            HyperLink9.NavigateUrl = "bookpdfThe-Guest-List.pdf";
            HyperLink10.NavigateUrl = "bookpdf/The-Guest-List.pdf";
            Label18.Text = "The Guest List is a contemporary murder mystery thriller novel published in 2020 by Lucy Foley. The story takes place on a remote island off the coast of Ireland, where a seemingly perfect wedding weekend turns deadly. The guests, a group of old friends and colleagues of the bride and groom, arrive on the island filled with hidden resentments and past secrets. As the festivities unfold, tensions rise, and shocking revelations come to light. When a body is discovered, the guests become trapped on the island with a murderer in their midst.\r\n\r\nThe novel is told from multiple perspectives, allowing the reader to see the events unfold through the eyes of different characters. This adds to the suspense and keeps the reader guessing about who the killer is and why they struck.";

        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Label2.Text = "Science Fiction Books";
            Image2.ImageUrl = "~/Scripts/WebForms/sf.jpg";


            Image3.ImageUrl = "~/bookimagecover/time.jpg";
            Label4.Text = "The Time Machine";
            Label5.Text = " H.G. Wells";
            HyperLink1.NavigateUrl = "bookpdf/the-time-machine.pdf";
            HyperLink2.NavigateUrl = "bookpdf/the-time-machine.pdf";
            Label6.Text = "H.G. Wells's science fiction classic, The Time Machine, follows a Victorian inventor on a mind-bending journey. He builds a machine that allows him to travel through time, landing far in the future at around 800,000 years from his own time. There, he discovers a society divided into two starkly different races. The above-ground dwellers, the Eloi, are beautiful but childlike and dependent. Below ground lurk the Morlocks, pale, subterranean creatures who seem to control the Eloi's fate. The Time Traveller faces dangers from both groups as he explores this strange new world.";


            Image4.ImageUrl = "~/bookimagecover/foundation.jpg";
            Label7.Text = " The Foundation Trilogy";
            Label8.Text = "Isaac Asimov";
            HyperLink3.NavigateUrl = "bookpdf/foundation.pdf";
            HyperLink4.NavigateUrl = "bookpdf/foundation.pdf";
            Label9.Text = "The first book in Isaac Asimov's Foundation Trilogy, simply titled \"Foundation,\" takes place in a vast, aging Galactic Empire. A mathematician named Hari Seldon creates a new science called psychohistory, which predicts the future by analyzing massive populations. Through psychohistory, Seldon foresees the Empire's imminent collapse and a dark age lasting millennia.\r\n\r\nTo mitigate this dark age, Seldon establishes the Foundation on a remote planet. This Foundation gathers the best minds and knowledge of the Empire, aiming to preserve civilization and shorten the dark age. The book follows the Foundation's early struggles as it navigates a galaxy on the brink of chaos, using science and knowledge as tools for survival.";


            Image5.ImageUrl = "~/bookimagecover/snow-crash.jpg";
            Label10.Text = "Snow Crash";
            Label11.Text = "Neal Stephenson";
            HyperLink5.NavigateUrl = "bookpdf/Snow Crash.pdf";
            HyperLink6.NavigateUrl = "bookpdf/Snow Crash.pdf";
            Label12.Text = "Neal Stephenson's cyberpunk classic, Snow Crash, takes place in a fractured Los Angeles of the future. Mega-corporations rule, wielding private armies in a world fragmented after an economic collapse. Our unlikely hero, Hiro Protagonist, is a hacker by night, delivering pizzas for the Mafia by day. When a mysterious new drug called Snow Crash surfaces, it infects both the digital and real worlds. Hiro gets pulled into a conspiracy that forces him to navigate the virtual reality realm known as the Metaverse, all while wielding samurai swords and dodging corporate goons.";


            Image6.ImageUrl = "~/bookimagecover/dune.jpg";
            Label13.Text = "Dune";
            Label14.Text = " Frank Herbert";
            HyperLink7.NavigateUrl = "bookpdf/dune.pdf";
            HyperLink8.NavigateUrl = "bookpdf/dune.pdf";
            Label15.Text = "In Frank Herbert's \"Dune,\" Duke Leto Atreides, a noble leader, takes his house to govern the harsh desert planet Arrakis. This seemingly unfortunate assignment is actually a trap set by their rivals, the cruel Harkonnens. Arrakis holds the key to galactic power: spice, a valuable drug that extends life and allows for interstellar travel. Paul, Duke Leto's son, trains in fighting and mystical powers alongside his mother, Lady Jessica, who belongs to a secretive sisterhood. As Paul navigates this unforgiving world, he may be the one to unite the native Fremen and change the fate of Arrakis.";


            Image7.ImageUrl = "~/bookimagecover/jurassic-park.png";
            Label16.Text = "Jurassic Park";
            Label17.Text = "Michael Crichton";
            HyperLink9.NavigateUrl = "bookpdf/JurassicPark.pdf";
            HyperLink10.NavigateUrl = "bookpdf/JurassicPark.pdf";
            Label18.Text = "In Michael Crichton's Jurassic Park, billionaire John Hammond fulfills a lifelong dream by creating a theme park populated by cloned dinosaurs. Geneticists use preserved mosquito DNA trapped in amber to bring these prehistoric giants back to life. A group of invited guests, including paleontologists, get a first look at the wonders of Jurassic Park. But excitement soon turns to terror as a system malfunction leads to a power outage, disabling the fences that confine the dinosaurs. With cunning and ferocious predators now roaming free, the characters fight for survival in a desperate struggle against nature's resurrected might.";

        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Label2.Text = "Romance Books";
            Image2.ImageUrl = "~/Scripts/WebForms/r.jpg";


            Image3.ImageUrl = "~/bookimagecover/ends-with.jpeg";
            Label4.Text = "It Ends With Us";
            Label5.Text = "Colleen Hoover";
            HyperLink1.NavigateUrl = "bookpdf/it-ends-with-us.pdf";
            HyperLink2.NavigateUrl = "bookpdf/it-ends-with-us.pdf";
            Label6.Text = "Colleen Hoover's \"It Ends With Us\" is a complex romance novel that explores themes of domestic violence, first love, and finding your strength. Lily Bloom, the protagonist, is a young woman who has just moved to Boston to start fresh. She's haunted by the memories of her abusive father and finds solace in her work as a florist.\r\n\r\nLily's world is turned upside down when she meets Ryle Kincaid, a handsome and brooding neurosurgeon. Their connection is intense, but Ryle is adamant about not wanting a serious relationship.\r\n\r\nAs Lily delves deeper into her relationship with Ryle, she also begins to revisit her past through her teenage journals.  These journals tell the story of her first love, Atlas Corrigan, a homeless boy she met as a teenager. Atlas became her confidante and protector during a difficult time in her life.";


            Image4.ImageUrl = "~/bookimagecover/happy.jpg";
            Label7.Text = "Happy Place";
            Label8.Text = " Emily Henry";
            HyperLink3.NavigateUrl = "bookpdf/Happy Place.pdf";
            HyperLink4.NavigateUrl = "bookpdf/Happy Place.pdf";
            Label9.Text = "The phrase \"Happy Place\" might refer to the recent novel by Emily Henry. It's a story about Harriet, who goes on a vacation with her ex-boyfriend and best friends. The trip takes them back to their annual hangout spot, a place filled with memories of their past relationship and happier times.  The book explores themes of love, loss, and the complexities of friendship.";


            Image5.ImageUrl = "~/bookimagecover/the-deal.jpg";
            Label10.Text = "The Deal";
            Label11.Text = "Elle Kennedy";
            HyperLink5.NavigateUrl = "bookpdf/The-Deal.pdf";
            HyperLink6.NavigateUrl = "bookpdf/The-Deal.pdf";
            Label12.Text = "In Elle Kennedy's novel \"The Deal,\" studious Hannah has a crush on a gorgeous hockey player, Garrett, who's failing a class. Hannah excels in that subject, so Garrett proposes a deal: she tutors him in exchange for a pretend date. Despite clashing personalities - Hannah's all focus and Garrett's known for being cocky - their undeniable attraction simmers. As they spend more time together, lines blur, and Hannah grapples with her emotional baggage surrounding intimacy while their connection deepens.";


            Image6.ImageUrl = "~/bookimagecover/the-fault.jpg";
            Label13.Text = "The Fault In Our Stars";
            Label14.Text = "John Green";
            HyperLink7.NavigateUrl = "bookpdf/the-fault.pdf";
            HyperLink8.NavigateUrl = "bookpdf/the-fault.pdf";
            Label15.Text = "Sixteen-year-old Hazel Grace Lancaster battles cancer, relying on an oxygen tank to breathe. Feeling isolated by her illness, she's forced by her parents to attend a support group. There, she meets Augustus Waters, a charming amputee and cancer survivor. Drawn to each other, they embark on a whirlwind romance, fueled by their shared experiences and a mysterious novel about a cancer-stricken girl. Their love story blossoms amidst the harsh realities of their illness, forcing them to confront life, love, and loss.";


            Image7.ImageUrl = "~/bookimagecover/the-hating-game.jpg";
            Label16.Text = "The Hating Game";
            Label17.Text = "Sally Thorne";
            HyperLink9.NavigateUrl = "bookpdf/The-Hating-Game.pdf";
            HyperLink10.NavigateUrl = "bookpdf/The-Hating-Game.pdf";
            Label18.Text = "Trapped in a hilarious competition of one-upmanship, Lucy Hutton and Joshua Templeton are co-workers embroiled in a fiery feud.  Both vying for the same promotion, their desks positioned directly across from each other become battlegrounds. Lucy, the perfectly organized romantic comedy heroine, finds herself inexplicably drawn to the infuriatingly meticulous Joshua.  Their playful sabotage escalates, fueled by a hidden attraction that neither dares admit.  This enemies-to-lovers story is a delightful mix of witty banter and simmering tension.";

        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Label2.Text = "Adventure Books";
            Image2.ImageUrl = "~/Scripts/WebForms/aa.jpg";


            Image3.ImageUrl = "~/bookimagecover/info-wild.jpeg";
            Label4.Text = "Into The Wild";
            Label5.Text = "Jon Krakauer";
            HyperLink1.NavigateUrl = "bookpdf/into-the-wild.pdf";
            HyperLink2.NavigateUrl = "bookpdf/into-the-wild.pdf";
            Label6.Text = "Jon Krakauer's \"Into the Wild\" delves into the true story of Christopher McCandless. After graduating college, McCandless sheds his identity, becoming \"Alexander Supertramp,\" and embarks on a journey into the Alaskan wilderness. Driven by a desire to escape materialism and societal constraints, he casts off his possessions and severs ties with his family. The book follows both McCandless's trek north and Krakauer's attempt to understand his motivations, weaving a tale of adventure, self-discovery, and the harsh realities of nature.";


            Image4.ImageUrl = "~/bookimagecover/road.jpg";
            Label7.Text = "The Road";
            Label8.Text = "Cormac Mc Carthy";
            HyperLink3.NavigateUrl = "bookpdf/the-road.pdf";
            HyperLink4.NavigateUrl = "bookpdf/the-road.pdf";
            Label9.Text = "Cormac McCarthy's \"The Road\" chronicles a bleak journey. A man and his young son traverse a desolate, post-apocalyptic America. The world is a wasteland, choked by ash and devoid of life. They push a shopping cart, scavenging for food and fending off threats in a constant struggle for survival. Their love for each other provides a fragile spark of hope amidst the surrounding darkness.";


            Image5.ImageUrl = "~/bookimagecover/right.jpg";
            Label10.Text = "The Right Stuff";
            Label11.Text = "Tom Wolfe";
            HyperLink5.NavigateUrl = "bookpdf/The Right Stuff.pdf";
            HyperLink6.NavigateUrl = "bookpdf/The Right Stuff.pdf";
            Label12.Text = "Tom Wolfe's \"The Right Stuff\" dives into the world of America's early astronauts and the test pilots who paved the way. It chronicles their daring flights in experimental aircraft and the grueling selection process for Project Mercury, the first human spaceflight program. The book explores what it meant to have \"the right stuff\" – that indefinable quality of courage, coolness, and bravado needed to be a pioneer in space. It delves into the lives of the Mercury Seven astronauts, their families, and other test pilots, contrasting ambition with personal struggles during this historic moment in the Space Race.";


            Image6.ImageUrl = "~/bookimagecover/the-lightning-thief.jpeg";
            Label13.Text = "The Lightning Thief";
            Label14.Text = "Rick Riordan";
            HyperLink7.NavigateUrl = "bookpdf/The-Lightning-Thief.pdf";
            HyperLink8.NavigateUrl = "bookpdf/The-Lightning-Thief.pdf";
            Label15.Text = "Twelve-year-old Percy Jackson, a troubled boy with ADHD and dyslexia, is on a school trip when his world is turned upside down. His seemingly ordinary math teacher transforms into a monstrous Fury and attacks him. With the help of his favorite teacher, Mr. Brunner (revealed to be a centaur named Chiron), Percy learns he's a demigod, son of the sea god Poseidon. Accused of stealing Zeus' lightning bolt, Percy embarks on a cross-country quest with his loyal satyr friend Grover and a clever daughter of Athena, Annabeth. They face mythical creatures, navigate the dangers of the Underworld, and uncover a plot that could spark a war among the gods.";


            Image7.ImageUrl = "~/bookimagecover/treasure-island.jpg";
            Label16.Text = "Treasure Island";
            Label17.Text = "Robert Louis Stevenson";
            HyperLink9.NavigateUrl = "bookpdf/island.pdf";
            HyperLink10.NavigateUrl = "bookpdf/island.pdf";
            Label18.Text = "Treasure Island follows young Jim Hawkins who stumbles upon a mysterious map while living at his family's inn. The map, left behind by a deceased pirate, Billy Bones, marks the location of Captain Flint's hidden treasure. Jim joins a sailing expedition to the island, but soon discovers the crew is full of mutineers led by the one-legged Long John Silver. Thrust into danger, Jim must rely on his wit and courage to survive the treacherous journey, outsmart the pirates, and claim the treasure.";

        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Label2.Text = "Crime Books";
            Image2.ImageUrl = "~/Scripts/WebForms/nf.jpeg";


            Image3.ImageUrl = "~/bookimagecover/a-little.jpg";
            Label4.Text = "A Litter of Bones";
            Label5.Text = "JD Kirk";
            HyperLink1.NavigateUrl = "bookpdf/A-Litter-of-Bones.pdf";
            HyperLink2.NavigateUrl = "bookpdf/A-Litter-of-Bones.pdf";
            Label6.Text = "The story follows Detective Inspector Jack Logan, a troubled detective haunted by the past. Ten years ago, he apprehended a notorious serial child-killer known as \"Mister Whisper,\" but the experience left him scarred, both emotionally and personally. Now, working in Glasgow's Major Investigations Team, he's called upon to investigate the disappearance of another child, this time in the remote Scottish Highlands.\r\n\r\nAs Jack delves deeper into the case, he uncovers a web of secrets and faces a race against time to find the missing boy before it's too late. The novel explores themes of trauma, guilt, and redemption, set against the backdrop of the rugged Scottish landscape.";


            Image4.ImageUrl = "~/bookimagecover/cold-blood.jpeg";
            Label7.Text = "In Cold Blood";
            Label8.Text = "Truman Capote's";
            HyperLink3.NavigateUrl = "bookpdf/cold-blood.pdf";
            HyperLink4.NavigateUrl = "bookpdf/cold-blood.pdf";
            Label9.Text = "Truman Capote's \"In Cold Blood\" delves into the true story of the 1959 murders of the Clutter family in Holcomb, Kansas. The narrative unfolds in three parts. First, it meticulously details the seemingly ordinary lives of the Clutter family on the day they are brutally killed. Simultaneously, the book introduces the murderers, Perry Smith and Dick Hickock, following their journey towards Holcomb, driven by a desire for wealth. The story then shifts to the aftermath of the murders, capturing the shock and grief in the town alongside the extensive investigation and eventual capture of Smith and Hickock. The book concludes with their trial, execution, and reflections on the human cost of violence, leaving the reader to grapple with the complexities of the crime and its lasting impact.";


            Image5.ImageUrl = "~/bookimagecover/gone-girl.jpg";
            Label10.Text = "Gone Girl";
            Label11.Text = "Gillian Flynn";
            HyperLink5.NavigateUrl = "bookpdf/Gone-Girl.pdf";
            HyperLink6.NavigateUrl = "bookpdf/Gone-Girl.pdf";
            Label12.Text = "\"Gone Girl,\" by Gillian Flynn, throws you into a psychological thriller where Amy Dunne, the wife, mysteriously disappears on their fifth anniversary. The story unfolds through alternating chapters, revealing hidden truths. Nick, the husband, becomes the prime suspect under public scrutiny as his past indiscretions and odd behavior come to light. As the investigation deepens, Amy's diary entries unveil a different narrative, painting a picture of a troubled marriage and simmering resentment. With each twist and turn, the line between truth and manipulation blurs, leaving the reader questioning who is truly the victim and who is the villain.";


            Image6.ImageUrl = "~/bookimagecover/kill-joy.jpg";
            Label13.Text = "Kill Joy";
            Label14.Text = "Holly Jackson";
            HyperLink7.NavigateUrl = "bookpdf/kill-joy.pdf";
            HyperLink8.NavigateUrl = "bookpdf/kill-joy.pdf";
            Label15.Text = "Pip Fitz-Amobi, the brilliant teen detective from the \"A Good Girl's Guide to Murder\" series, isn't thrilled about her friend's elaborate murder mystery party set on a fictional island named Joy. However, the lines between playacting and reality blur when a real-life murder occurs. While Pip delves into the clues to solve the fictional murder, she can't shake the feeling that a dangerous killer might be lurking among the party guests. As secrets surface and another person turns up dead, Pip races against time to unmask the killer before they strike again.";


            Image7.ImageUrl = "~/bookimagecover/the-murder.jpeg";
            Label16.Text = "The Murder of Roger Ackroyd";
            Label17.Text = "Agatha Christie";
            HyperLink9.NavigateUrl = "bookpdf/The_Murder_of_Roger_Ackroyd-Agatha_Christie.pdf";
            HyperLink10.NavigateUrl = "bookpdf/The_Murder_of_Roger_Ackroyd-Agatha_Christie.pdf";
            Label18.Text = "In the quaint village of King's Abbot, the wealthy widower Roger Ackroyd is found murdered in his study.  Dr. Sheppard, the village physician and the novel's narrator, becomes entangled in the investigation alongside the retired, yet brilliant detective Hercule Poirot. Amidst a web of secrets, blackmail, and hidden motives, suspicion falls upon Ackroyd's household and those connected to the recent, seemingly suicidal death of a local woman. With its shocking and controversial twist ending,  \"The Murder of Roger Ackroyd\" is regarded as a masterpiece of the detective fiction genre, altering the landscape of crime writing.";

        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Label2.Text = "Horror Books";
            Image2.ImageUrl = "~/Scripts/WebForms/ho.jpeg";


            Image3.ImageUrl = "~/bookimagecover/hill-house.jpg";
            Label4.Text = "The Haunting of Hill House";
            Label5.Text = "Shirley Jackson";
            HyperLink1.NavigateUrl = "bookpdf/the-haunting-of-hill-house.pdf";
            HyperLink2.NavigateUrl = "bookpdf/the-haunting-of-hill-house.pdf";
            Label6.Text = "Shirley Jackson's \"The Haunting of Hill House\" centers on a peculiar mansion shrouded in a reputation for supernatural activity. Dr. Montague, a researcher of the paranormal, gathers a group to investigate the house, including Eleanor Vance, a woman sensitive to the supernatural. As they spend time within the imposing structure, strange occurrences plague them – doors slam shut on their own, objects move mysteriously, and unsettling sounds echo through the halls. The true nature of the haunting, whether it be malevolent spirits or a more psychological phenomenon, becomes increasingly blurred as the characters grapple with the house's unsettling influence, particularly Eleanor, who seems particularly susceptible to its hold.";


            Image4.ImageUrl = "~/bookimagecover/house-of-leaves.jpg";
            Label7.Text = "House of Leaves";
            Label8.Text = "Mark Z.Danielewski";
            HyperLink3.NavigateUrl = "bookpdf/House-of-Leaves.pdf";
            HyperLink4.NavigateUrl = "bookpdf/House-of-Leaves.pdf";
            Label9.Text = "\"House of Leaves\" is a labyrinthine novel presented through multiple layers of narration. The main story follows the Navidson family who move into a seemingly ordinary house that defies the laws of physics. Strange occurrences like new doors appearing in walls and hallways defying spatial logic start to unravel their sanity. We experience this story through the \"Navidson Record,\" a documentary filmed by the husband, interspersed with footnotes and commentary by another character named Johnny Truant. This unique structure and the unsettling nature of the house make \"House of Leaves\" a thought-provoking and challenging read.";


            Image5.ImageUrl = "~/bookimagecover/the-shining.jpg";
            Label10.Text = "The Shining";
            Label11.Text = "Stephen King";
            HyperLink5.NavigateUrl = "bookpdf/The-Shining.pdf";
            HyperLink6.NavigateUrl = "bookpdf/The-Shining.pdf";
            Label12.Text = "In Stephen King's \"The Shining,\" Jack Torrance, a struggling writer and recovering alcoholic, takes a job as the winter caretaker of the isolated Overlook Hotel. He brings his wife Wendy and son Danny, who possesses a psychic ability called \"the shining.\" During their stay, the grandeur and isolation of the hotel, coupled with its dark history, begin to take their toll on Jack. As winter sets in, the hotel's sinister influence amplifies, manipulating Jack and turning him against his family. Danny, relying on his shining, must fight for their survival against the hotel's evil forces and a deranged Jack.";


            Image6.ImageUrl = "~/bookimagecover/the-stand.jpeg";
            Label13.Text = "The Stand";
            Label14.Text = "Stephen King";
            HyperLink7.NavigateUrl = "bookpdf/The-Stand.pdf";
            HyperLink8.NavigateUrl = "bookpdf/The-Stand.pdf";
            Label15.Text = "Stephen King's epic novel, The Stand, throws humanity into a fight for survival after a deadly superflu wipes out most of the population. The remaining individuals grapple with the remnants of society, drawn towards two opposing forces. Some, guided by visions of a benevolent woman named Mother Abigail, strive to rebuild a just society in Boulder, Colorado. Others, swayed by the dark and charismatic Randall Flagg, gravitate towards Las Vegas, forming a hedonistic community. As these groups solidify, a conflict brews, forcing the survivors to pick a side in the ultimate battle between good and evil.";


            Image7.ImageUrl = "~/bookimagecover/women-black.jpeg";
            Label16.Text = "The Woman In Black";
            Label17.Text = "Susan Hill";
            HyperLink9.NavigateUrl = "bookpdf/woman-in-black.pdf";
            HyperLink10.NavigateUrl = "bookpdf/woman-in-black.pdf";
            Label18.Text = "The Woman in Black is a chilling Gothic horror novella by Susan Hill. It follows the story of Arthur Kipps, a young solicitor who travels to the isolated town of Crythin Gifford to settle the affairs of the deceased Alice Drablow.  At her desolate home, Eel Marsh House, and throughout the town, Kipps encounters a spectral figure – a woman dressed entirely in black. This mysterious apparition is linked to a horrifying curse; wherever she appears, the tragic death of a child soon follows. Arthur becomes entangled in the town's tragic past and the vengeful spirit's history, racing against time to break the curse.";

        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Label2.Text = "Biography Books";
            Image2.ImageUrl = "~/Scripts/WebForms/bh.jpg";


            Image3.ImageUrl = "~/bookimagecover/albert.jpg";
            Label4.Text = "Einstein His Life And Universe";
            Label5.Text = "Walter Isaacson";
            HyperLink1.NavigateUrl = "bookpdf/albert.pdf";
            HyperLink2.NavigateUrl = "bookpdf/albert.pdf";
            Label6.Text = "Walter Isaacson's \"Einstein: His Life and Universe\" delves into the world of the iconic physicist. It explores his journey, from his inquisitive childhood that sparked his genius to the groundbreaking theories that reshaped our understanding of the universe. The book sheds light on both his scientific triumphs, like the famous E=mc² equation, and his personal struggles. It portrays Einstein as a man of independent thought, whose rebellious nature fueled his creativity but also caused friction in academia. Isaacson follows Einstein through his life, revealing not just the brilliance but also the human side of this scientific legend.";


            Image4.ImageUrl = "~/bookimagecover/experiments.jpg";
            Label7.Text = "The Story of My Experiments With Truth";
            Label8.Text = "M.K. Gandhi";
            HyperLink3.NavigateUrl = "bookpdf/experiments.pdf";
            HyperLink4.NavigateUrl = "bookpdf/experiments.pdf";
            Label9.Text = "Mahatma Gandhi's autobiography, \"The Story of My Experiments with Truth,\" is a unique window into his life from childhood to 1921. Written in installments, it delves into his early experiences, including moral struggles and influential stories. The book reveals the foundation of his beliefs, shaped by concepts like truthfulness and unwavering devotion to duty. It doesn't cover his later, widely known period leading India's independence movement. Instead, the focus is on Gandhi's personal journey and the core values that guided him on his path.";


            Image5.ImageUrl = "~/bookimagecover/elon.jpg";
            Label10.Text = "Elon Musk";
            Label11.Text = "Ashlee Vance";
            HyperLink5.NavigateUrl = "bookpdf/Elon.pdf";
            HyperLink6.NavigateUrl = "bookpdf/Elon.pdf";
            Label12.Text = "There isn't a single definitive biography written by Elon Musk himself. However, several biographies explore his life and achievements. One prominent example isAshlee Vance's \"Elon Musk\"  which delves into his upbringing in South Africa, his early talent for technology, and the struggles and triumphs that shaped him into the visionary entrepreneur we know today. The book likely explores his motivations for companies like Tesla and SpaceX, offering a window into his ambition to revolutionize transportation and space exploration.";


            Image6.ImageUrl = "~/bookimagecover/helen.jpg";
            Label13.Text = "The Story of My Life";
            Label14.Text = "Helen Keller";
            HyperLink7.NavigateUrl = "bookpdf/helen.pdf";
            HyperLink8.NavigateUrl = "bookpdf/helen.pdf";
            Label15.Text = "\"The Story of My Life\" is an autobiography by Helen Keller. It details her struggles and triumphs growing up deaf and blind.  The book focuses on her early years, particularly the arrival of her dedicated teacher, Anne Sullivan, who breaks through the isolation of Helen's world. Through touch and finger spelling, Helen begins to grasp language and connect with the world around her. \"The Story of My Life\" is a testament to the power of education and human connection in overcoming seemingly insurmountable challenges.";


            Image7.ImageUrl = "~/bookimagecover/wings.jpg";
            Label16.Text = "Wings of Fire";
            Label17.Text = "A.P.J. Abdul Kalam";
            HyperLink9.NavigateUrl = "bookpdf/wings.pdf";
            HyperLink10.NavigateUrl = "bookpdf/wings.pdf";
            Label18.Text = "Autobiography: The most famous \"Wings of Fire\" is the autobiography of Dr. A. P. J. Abdul Kalam, the former president of India. It details his rise from a humble background to become a leading Indian scientist in the space and missile programs.\r\nFantasy Series: There's also a popular fantasy series for young adults called \"Wings of Fire\" by Tui T. Sutherland. This series follows five young dragons from different tribes who train at a special academy. They face a dark prophecy and must work together to prevent a terrible future.";

        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Label2.Text = "Action Books";
            Image2.ImageUrl = "~/Scripts/WebForms/aa.jpg";


            Image3.ImageUrl = "~/bookimagecover/lost-horizon.jpg";
            Label4.Text = "Lost Horizon";
            Label5.Text = "James Hilton";
            HyperLink1.NavigateUrl = "bookpdf/Lost-Horizon.pdf";
            HyperLink2.NavigateUrl = "bookpdf/Lost-Horizon.pdf";
            Label6.Text = "In James Hilton's novel, Lost Horizon, a group of strangers, including a jaded British diplomat named Hugh Conway, are kidnapped on a plane ride and deposited in the mystical Himalayan valley of Shangri-La. This hidden paradise is a utopia ruled by benevolent monks, offering peace, beauty, and an extended lifespan. Conway finds himself captivated by this idyllic existence, but a yearning for the outside world and a sense of duty battle with his newfound serenity. The story explores themes of materialism vs. spiritualism, Western vs. Eastern philosophies, and the allure of a timeless escape.";


            Image4.ImageUrl = "~/bookimagecover/sea.jpg";
            Label7.Text = "The Sea of Monsters";
            Label8.Text = "Rick Riordan";
            HyperLink3.NavigateUrl = "bookpdf/The Sea of Monsters.pdf";
            HyperLink4.NavigateUrl = "bookpdf/The Sea of Monsters.pdf";
            Label9.Text = "In \"The Sea of Monsters,\" Percy Jackson's summer break takes a monstrous turn. Strange dreams and attacks by mythical creatures plague him. When his friend Grover is captured by a cyclops, Percy, along with Annabeth and a new friend Tyson, defy orders and embark on a daring quest. Their goal:  find the Golden Fleece, the only thing that can save Camp Half-Blood and rescue Grover.";


            Image5.ImageUrl = "~/bookimagecover/ender-s-game.jpg";
            Label10.Text = "Ender's Game";
            Label11.Text = "Orson Scott Card";
            HyperLink5.NavigateUrl = "bookpdf/EndersGame.pdf";
            HyperLink6.NavigateUrl = "bookpdf/EndersGame.pdf";
            Label12.Text = "Ender Wiggin, a brilliant but troubled young boy, is humanity's hope against a deadly alien race called the Buggers. Earth barely survived two prior invasions, and Ender is sent to Battle School, a space station training child soldiers. Through brutal training simulations, Ender's strategic genius shines. He isolates himself, excelling but facing jealousy and manipulation. Believing he's playing elaborate war games, Ender wins every battle, but a shocking truth awaits him.";


            Image6.ImageUrl = "~/bookimagecover/game.jpg";
            Label13.Text = "A Game of Thrones";
            Label14.Text = "George R.R. Martin";
            HyperLink7.NavigateUrl = "bookpdf/game.pdf";
            HyperLink8.NavigateUrl = "bookpdfgame.pdf/";
            Label15.Text = "In a world of unpredictable seasons, a summer stretching for years abruptly ends. King Robert Baratheon, who seized the throne from the Targaryen dynasty, summons Lord Eddard Stark, a man of honor, to be his advisor.  Meanwhile, across the Narrow Sea, Daenerys Targaryen, daughter of the ousted king, is married off to a barbarian warlord in exchange for an army to reclaim her birthright.  As dark forces stir beyond a massive wall protecting the south, noble families begin a deadly game of power for control of the Iron Throne.";


            Image7.ImageUrl = "~/bookimagecover/six.jpg";
            Label16.Text = "Six of Crows";
            Label17.Text = "Leigh Bardvgo";
            HyperLink9.NavigateUrl = "bookpdf/six.pdf";
            HyperLink10.NavigateUrl = "bookpdf/six.pdf";
            Label18.Text = "Six of Crows dives into a fantasy world with a heist at its heart. The story unfolds in Ketterdam, a bustling criminal hub reminiscent of Amsterdam. Here, we meet Kaz Brekker, a cunning teenager who leads a gang. He's presented with a tempting offer: to break into an impenetrable prison, the Ice Court, and liberate a powerful Grisha scientist. Grisha, in this world, are people with magical abilities. To achieve this near-impossible feat, Kaz assembles a crew of five other teenagers, each with their own unique skills and secrets. Together, they embark on a thrilling adventure filled with danger, suspense, and high stakes.";

        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Label2.Text = "Children's Books";
            Image2.ImageUrl = "~/Scripts/WebForms/c.jpeg";


            Image3.ImageUrl = "~/bookimagecover/love.jpeg";
            Label4.Text = "Love You Forever";
            Label5.Text = "Robert Munsch";
            HyperLink1.NavigateUrl = "bookpdf/love.pdf";
            HyperLink2.NavigateUrl = "bookpdf/love.pdf";
            Label6.Text = "\"Love You Forever\" is a children's book about a mother's unwavering love for her son. Through catchy rhymes and expressive illustrations, it follows him from mischievous child to grumpy teenager and eventually a grown man. Despite his antics, the mother sings him a lullaby every night, promising her love will always be there. The tables turn as the mother grows old, and the son, now a father himself, sings the lullaby back to her, showcasing the enduring bond between parent and child.";


            Image4.ImageUrl = "~/bookimagecover/a-wrinkle-in-time.jpg";
            Label7.Text = "A Wrinkle In Time";
            Label8.Text = "Madeleine L'Engle";
            HyperLink3.NavigateUrl = "bookpdf/A Wrinkle in Time.pdf";
            HyperLink4.NavigateUrl = "bookpdf/A Wrinkle in Time.pdf";
            Label9.Text = "Unpopular teenager Meg Murry and her brainy brother Charles Wallace yearn for their scientist father who vanished on a mysterious project. Led by three peculiar women, Mrs. Whatsit, Who, and Which, they embark on a mind-bending journey through time and space. Joining them is their classmate Calvin. Together, they travel to strange planets battling a dark evil force called IT, all in the hopes of rescuing their father and saving the universe.";


            Image5.ImageUrl = "~/bookimagecover/garden.jpeg";
            Label10.Text = "The Secret Graden";
            Label11.Text = "Frances Hodgdon Burnett";
            HyperLink5.NavigateUrl = "bookpdf/The Secret Garden.pdf";
            HyperLink6.NavigateUrl = "bookpdf/The Secret Garden.pdf";
            Label12.Text = "Orphaned Mary Lennox, a grumpy and lonely girl, is sent to live with her reclusive uncle at Misselthwaite Manor on the Yorkshire moors. The brooding manor hides a secret: a locked garden, locked shut since Mary's aunt died. With the help of a friendly robin and a kind young maid, Mary discovers the hidden key and begins to unlock the mysteries of the garden and herself. As Mary breathes life back into the neglected garden, it works its magic on her, transforming her into a healthier and happier girl.";


            Image6.ImageUrl = "~/bookimagecover/the-railway-children.jpg";
            Label13.Text = "The Railway Children";
            Label14.Text = "E. Nesbit";
            HyperLink7.NavigateUrl = "bookpdf/The Railway Children.pdf";
            HyperLink8.NavigateUrl = "bookpdf/The Railway Children.pdf";
            Label15.Text = "E. Nesbit's \"The Railway Children\" tells the story of three siblings, Roberta, Peter, and Phyllis. Their comfortable life in London is upended when their father is mysteriously imprisoned. The family moves to a small cottage near a railway line. Initially lonely, the children find adventure and friendship through the trains rumbling past their home. They encounter kind characters like the station porter and a mysterious gentleman. As they explore and help others, the children grapple with their father's absence, hoping for his return.";


            Image7.ImageUrl = "~/bookimagecover/peter-and-wendy.jpg";
            Label16.Text = "Peter And Wendy";
            Label17.Text = "J.M. Barrie";
            HyperLink9.NavigateUrl = "bookpdf/peter.pdf";
            HyperLink10.NavigateUrl = "bookpdf/peter.pdf";
            Label18.Text = "\r\nIn J.M. Barrie's \"Peter and Wendy,\" Wendy Darling befriends Peter Pan, a boy who refuses to grow up. After Peter loses his shadow, Wendy joins him on a magical flight to Neverland, a land where children never age. There, she encounters the Lost Boys, a band of Peter's companions, and has fantastical adventures with mermaids, Indians, and even pirates led by the villainous Captain Hook. Wendy acts as a mother figure to the Lost Boys, but ultimately feels the pull of home and family. The story explores themes of childhood, growing up, and the power of imagination.";

        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Session["uname"] = Label1.Text.ToString();
            Response.Redirect("newpass.aspx");
        }
    }
}