using Microsoft.EntityFrameworkCore;
using Songs_Manager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Songs_Manager.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var now = DateTime.Now;

            modelBuilder.Entity<Artist>().HasData(
                new Artist
                {
                    ArtistId = 1,
                    Name = "Taylor Swift",
                    Slug = "taylor-swift",
                    Country = "U.S.A",
                    Bio = "<b>Taylor Alison Swift </b>(born December 13, 1989)<b></b> is an American singer-songwriter. Raised in Wyomissing, Pennsylvania, Swift moved to Nashville, Tennessee at 14 to pursue a career in country music. She signed with the independent label Big Machine Records and became the youngest songwriter ever hired by the Sony/ATV Music publishing house. The release of Swift's self-titled debut album in 2006 established her as a country music star. \"Our Song\", her third single, made her the youngest person to single-handedly write and perform a number one song on the Hot Country Songs chart. She received a Best New Artist nomination at the 2008 Grammy Awards.<br>"
                },
                new Artist
                {
                    ArtistId = 2,
                    Name = "Demi Lovato",
                    Slug = "demi-lovato",
                    Country = "U.S.A",
                    Bio = "Taylor Alison Swift (born December 13, 1989) is an American singer-songwriter. Raised in Wyomissing, Pennsylvania, Swift moved to Nashville, Tennessee at 14 to pursue a career in country music. She signed with the independent label Big Machine Records and became the youngest songwriter ever hired by the Sony/ATV Music publishing house. The release of Swift's self-titled debut album in 2006 established her as a country music star. \"Our Song\", her third single, made her the youngest person to single-handedly write and perform a number one song on the Hot Country Songs chart. She received a Best New Artist nomination at the 2008 Grammy Awards."
                },
                new Artist
                {
                    ArtistId = 3,
                    Name = "Katy Perry",
                    Slug = "katy-perry",
                    Country = "USA",
                    Bio = "Katheryn Elizabeth \"Katy\" Hudson (born October 25, 1984), better known by her stage name Katy Perry, is an American singer, songwriter, businesswoman, philanthropist, and actress. She was born near Santa Barbara, California and primarily grew up there before moving to Los Angeles. Having had limited exposure to mainstream pop music in her childhood, she pursued a career in gospel music as a teen and released her debut studio album, Katy Hudson (2001). She later recorded a collaborative album with The Matrix and a solo album she worked on with Glen Ballard, the latter of which was never released."
                },
                new Artist
                {
                    ArtistId = 4,
                    Name = "Eminem",
                    Slug = "eminem",
                    Country = "U.S.A",
                    Bio = "Marshall Bruce Mathers III (born October 17, 1972), known professionally as Eminem, is an American rapper, songwriter, record producer, record executive and actor. He is one of the most successful musical artists of the 21st century. In addition to his solo career, Eminem was a member of the hip hop group D12. He is also known for collaborations with fellow Detroit-based rapper Royce da 5'9 the two are collectively known as Bad Meets Evil."
                },
                new Artist
                {
                    ArtistId = 5,
                    Name = "50 Cent",
                    Slug = "50-cent",
                    Country = "U.S.A",
                    Bio = "Curtis James Jackson III (born July 6, 1975),known professionally as 50 Cent, is an American rapper, actor, producer, and entrepreneur. Born in the South Jamaica neighborhood of the borough of Queens, Jackson began selling drugs at age twelve during the 1980s crack epidemic. He later began pursuing a musical career and in 2000 he produced Power of the Dollar for Columbia Records, but days before the planned release he was shot and the album was never released. In 2002, after Jackson released the compilation album Guess Who's Back?, he was discovered by Eminem and signed to Shady Records, under the aegis of Dr. Dre's Aftermath Entertainment and Interscope Records."
                },
                new Artist
                {
                    ArtistId = 6,
                    Name = "Maitre Gims",
                    Slug = "maitre-gims",
                    Country = "France",
                    Bio = "Gandhi Bilel Djuna (born 6 May 1986), better known by his stage name Maître Gims is a Congolese singer, rapper and composer. He grew up in France and currently lives in France . He is a former member of the hip hop group Sexion d'Assaut, and released his major label debut album, Subliminal, in 2013. The album went to sell over one million copies in France and peaked at number two in the French album chart. His next two albums reached number one in France and Belgium (Wallonia) and peaked on the top 40 across various European countries, including Denmark, Italy and Switzerland. He topped the French singles chart four times, including once as a featured artist, most recently in 2018 with his song \"La meme\". The song was the most played in France in 2018 and it helped Gims to become the most played artist on French TV and radio for the same year."
                },
                new Artist
                {
                    ArtistId = 7,
                    Name = "Dafina Zeqiri",
                    Slug = "dafina-zeqiri",
                    Country = "Kosova",
                    Bio = "Dafina Zeqiri was born on 14 April 1989 into a Kosovo Albanian family in the city of Varberg, Sweden. Zeqiri's father was distant to her and to her mother, and she quoted that they haven't had contacts for more than 23 years. During a TV show in Klan Kosova, Dafina's father made a public speech asking her to forgive him, but Dafina never made any replies. In 2014, Zeqiri made a song with Ledri Vula, a Kosovar rapper from Pristina, whom she dated. There were a lot of rumors regarding their relationship, but they finally confirmed it during an acceptance speech in Videofest where the couple kissed. They later broke up."
                }
            );
            modelBuilder.Entity<Song>().HasData(
                new Song
                {
                    SongId = 1,
                    Name = "Blank Space",
                    Slug = "blank-space",
                    Featured = true,
                    Album = "1989 (2014)",
                    Lyrics = "<br><div>Nice to meet you, where you been?<br>I could show you incredible things<br>Magic, madness, heaven, sin<br>Saw you there and I thought<br>Oh my God, look at that face<br>You look like my next mistake<br>Love's a game, wanna play?<br><br>New money, suit and tie<br>I can read you like a magazine<br>Ain't it funny, rumors fly<br>And I know you heard about me<br>So hey, let's be friends<br>I'm dying to see how this one ends<br>Grab your passport and my hand<br>I can make the bad guys good for a weekend<br><br>So it's gonna be forever<br>Or it's gonna go down in flames<br>You can tell me when it's over<br>If the high was worth the pain<br>Got a long list of ex-lovers<br>They'll tell you I'm insane<br>'Cause you know I love the players<br>And you love the game<br><br>'Cause we're young and we're reckless<br>We'll take this way too far<br>It'll leave you breathless<br>Or with a nasty scar<br>Got a long list of ex-lovers<br>They'll tell you I'm insane<br>But I've got a blank space, baby<br>And I'll write your name<br><br>Cherry lips, crystal skies<br>I could show you incredible things<br>Stolen kisses, pretty lies<br>You're the King, baby, I'm your Queen<br>Find out what you want<br>Be that girl for a month<br>Wait, the worst is yet to come, oh no<br><br>Screaming, crying, perfect storms<br>I can make all the tables turn<br>Rose garden filled with thorns<br>Keep you second guessing like<br>\"Oh my God, who is she ? \"<br>I get drunk on jealousy<br>But you'll come back each time you leave<br>'Cause, darling, I'm a nightmare dressed like a daydream<br><br>So it's gonna be forever<br>Or it's gonna go down in flames<br>You can tell me when it's over<br>If the high was worth the pain<br>Got a long list of ex-lovers<br>They'll tell you I'm insane<br>'Cause you know I love the players<br>And you love the game<br><br>'Cause we're young and we're reckless<br>We'll take this way too far<br>It'll leave you breathless<br>Or with a nasty scar<br>Got a long list of ex-lovers<br>They'll tell you I'm insane<br>But I've got a blank space, baby<br>And I'll write your name<br><br>Boys only want love if it's torture<br>Don't say I didn't say, I didn't warn ya<br>Boys only want love if it's torture<br>Don't say I didn't say, I didn't warn ya<br><br>So it's gonna be forever<br>Or it's gonna go down in flames<br>You can tell me when it's over<br>If the high was worth the pain<br>Got a long list of ex-lovers<br>They'll tell you I'm insane<br>'Cause you know I love the players<br>And you love the game<br><br>'Cause we're young and we're reckless<br>We'll take this way too far<br>It'll leave you breathless<br>Or with a nasty scar<br>Got a long list of ex-lovers<br>They'll tell you I'm insane<br>But I've got a blank space, baby<br>And I'll write your name</div>",
                    UserName = "User 1"
                },
                new Song
                {
                    SongId = 2,
                    Name = "You Belong With Me",
                    Slug = "you-belong-with-me",
                    Featured = false,
                    Album = "Fearless (2008)",
                    Lyrics = "You're on the phone with your girlfriend<br>She's upset, she's going off about something that you said<br>'Cause she doesn't get your humor like I do.<br><br>I'm in the room, it's a typical Tuesday night.<br>I'm listening to the kind of music she doesn't like.<br>And she'll never know your story like I do.<br><br>But she wears short skirts<br>I wear T-shirts<br>She's cheer captain<br>And I'm on the bleachers<br>Dreaming about the day when you wake up and find<br>That what you're looking for has been here the whole time.<br><br>If you could see<br>That I'm the one<br>Who understands you.<br>Been here all along.<br>So, why can't you see<br>You belong with me,<br>You belong with me.<br><br>Walk in the streets with you in your worn-out jeans<br>I can't help thinking this is how it ought to be.<br>Laughing on a park bench thinking to myself,<br>\"Hey, isn't this easy?\"<br><br>And you've got a smile<br>That could light up this whole town.<br>I haven't seen it in a while<br>Since she brought you down.<br><br>You say you're fine I know you better than that.<br>Hey, what you doing with a girl like that?<br><br>She wears high heels,<br>I wear sneakers.<br>She's cheer captain,<br>And I'm on the bleachers.<br>Dreaming about the day when you wake up and find<br>That what you're looking for has been here the whole time.<br><br>If you could see<br>That I'm the one<br>Who understands you,<br>Been here all along.<br>So, why can't you see<br>You belong with me.<br><br>Standing by and waiting at your backdoor.<br>All this time how could you not know, baby?<br>You belong with me,<br>You belong with me.<br><br><i>[Instrumental]</i><br><br>Oh, I remember you driving to my house<br>In the middle of the night.<br>I'm the one who makes you laugh<br>When you know you're 'bout to cry.<br>I know your favorite songs,<br>And you tell me about your dreams.<br>Think I know where you belong,<br>Think I know it's with me.<br><br>Can't you see<br>That I'm the one<br>Who understands you?<br>Been here all along.<br>So, why can't you see<br>You belong with me.<br><br>Standing by and waiting at your backdoor.<br>All this time how could you not know, baby?<br>You belong with me,<br>You belong with me.<br><br>You belong with me.<br><br>Have you ever thought just maybe<br>You belong with me?<br>You belong with me.",
                    UserName = "User 1"
                },
                new Song
                {
                    SongId = 3,
                    Name = "Wildest Dreams",
                    Slug = "wildest-dreams",
                    Featured = false,
                    Album = "1989 (2014)",
                    Lyrics = "<br><div>He said, \"Let's get out of this town<br>Drive out of the city, away from the crowds\"<br>I thought heaven can't help me now<br>Nothing lasts forever, but this is gonna take me down<br><br>He's so tall and handsome as hell<br>He's so bad but he does it so well<br>I can see the end as it begins<br>My one condition is<br><br>Say you'll remember me<br>Standing in a nice dress<br>Staring at the sunset, babe<br>Red lips and rosy cheeks<br>Say you'll see me again<br>Even if it's just in your<br>Wildest dreams, ah-ha oh<br>Wildest dreams, ah-ha oh<br><br>I said, \"No one has to know what we do\"<br>His hands are in my hair, his clothes are in my room<br>And his voice is a familiar sound<br>Nothing lasts forever but this is getting good now<br><br>He's so tall and handsome as hell<br>He's so bad but he does it so well<br>And when we've had our very last kiss<br>My last request it is<br><br>Say you'll remember me<br>Standing in a nice dress<br>Staring at the sunset, babe<br>Red lips and rosy cheeks<br>Say you'll see me again<br>Even if it's just in your<br>Wildest dreams, ah-ha oh<br>Wildest dreams, ah-ha oh<br><br>You see me in hindsight<br>Tangled up with you all night<br>Burning it down<br>Someday when you leave me<br>I bet these memories<br>Follow you around<br><br>You'll see me in hindsight<br>Tangled up with you all night<br>Burning it down<br>Someday when you leave me<br>I bet these memories<br>Follow you around<br><br>Say you'll remember me<br>Standing in a nice dress<br>Staring at the sunset, babe<br>Red lips and rosy cheeks<br>Say you'll see me again<br>Even if it's just pretend<br><br>Say you'll remember me<br>Standing in a nice dress<br>Staring at the sunset, babe<br>Red lips and rosy cheeks<br>Say you'll see me again<br>Even if it's just in your (just pretend, just pretend)<br>Wildest dreams, ah-ha oh<br>In your wildest dreams, ah-ha oh<br>(Even if it's just in your wildest dreams) ah-ha<br>In your wildest dreams, ah-ha</div>",
                    UserName = "User 1"
                },
                new Song
                {
                    SongId = 4,
                    Name = "All Night Long",
                    Slug = "all-night-long",
                    Featured = false,
                    Album = "Unbroken(2011)",
                    Lyrics = "<p>I love the way you're talking<br>I'm loving what you're doing boy<br>I don't fall easy often<br>I've never had a love like you before<br><br>I like you, put your number, put your number in my phone, phone, phone, phone, phone, phone, phone, yeah<br>You heard me right so, call me, call me when you're all alone, lone, lone, lone, lone, lone, lone<br><br>Don't make plans<br>Come on with me, we'll stay up all night long<br>I want you, and I want you bad<br>Let's keep the party going all night long<br>Let's keep the party going all night long (hey)<br>All night long (hey), all night long (hey), all night, all night<br>All night long (hey), all night long (hey), all night, all night<br>A-a-a-all night<br><br>I'm on another planet<br>I'm in another universe<br>You may not understand it<br>Sooner or later baby you will learn<br><br>I like you, put your number, put your number in my phone, phone, phone, phone, phone, phone, phone, yeah<br>You heard me right so, call me, call me when you're all alone, lone, lone, lone, lone, lone, lone<br><br>Don't make plans<br>Come on with me, we'll stay up all night long<br>I want you, and I want you bad<br>Let's keep the party going all night long<br>Let's keep the party going all night long (hey)<br>All night long (hey), all night long (hey), all night, all night<br>All night long (hey), all night long (hey), all night, all night<br>A-a-a-all night<br><br><i>[Missy Elliott:]</i><br>We could party all night, night<br>Wanna spend a night, night<br>Will you be my type by the end of the night, we could pillow fight<br>Your Missy's real nice, come closer, cause I don't bite<br>You talking how I like, you play daddy, I play wife<br>I-I-I'm so alone, no-no-no one is home<br>I got your, got your na-na-number in my telephone<br>Wanna wanna wanna be your girl<br>Wanna wanna wanna be my babe<br>Boy we can hold hands, write our names in the sands<br>It's the weekend, don't make plans<br><br><i>[Demi Lovato &amp; Timbaland:]</i><br>Party's hot, when you're here<br>At the club, we don't care<br>We gonna set it off, we gonna set it off<br><br>Party's hot, when you're here<br>At the club, we don't care<br>We gonna set it off, we gonna set it off<br><br><i>[Demi Lovato:]</i><br>Don't make plans<br>Come on with me, we'll stay up all night long<br>I want you, and I want you bad<br>Let's keep the party going all night long<br>Let's keep the party going all night long (hey)<br>All night long (hey), all night long (hey), all night, all night<br>All night long (hey), all night long (hey), all night, all night<br>A-a-a-all night<br></p>",
                    UserName = "User 1"
                },
                new Song
                {
                    SongId = 5,
                    Name = "Give Your Heart a Break",
                    Slug = "give-your-heart-a-break",
                    Featured = true,
                    Album = "Unbroken (2011)",
                    Lyrics = "<br><div>The day I first met you<br>You told me you'd never fall in love<br>But now that I get you<br>I know fear is what it really was<br><br>Now here we are<br>So close yet so far<br>Haven't I passed the test?<br>When will you realize<br>Baby, I'm not like the rest?<br><br>Don't wanna break your heart<br>Wanna give your heart a break<br>I know you're scared it's wrong<br>Like you might make a mistake<br>There's just one life to live<br>And there's no time to wait, to wait<br>So let me give your heart a break, give your heart a break<br>Let me give your heart a break, your heart a break<br>Oh yeah, yeah<br><br>On Sunday you went home alone<br>There were tears in your eyes<br>I called your cell phone, my love<br>But you did not reply<br><br>The world is ours. If we want it<br>We can take it if you just take my hand<br>There's no turning back now<br>Baby, try to understand<br><br>Don't wanna break your heart<br>Wanna give your heart a break<br>I know you're scared it's wrong<br>Like you might make a mistake<br>There's just one life to live<br>And there's no time to wait, to wait<br>So let me give your heart a break, give your heart a break<br>Let me give your heart a break, your heart a break<br>There's just so much you can take<br>Give your heart a break<br>Let me give your heart a break, your heart a break<br>Oh yeah, yeah<br><br>When your lips are on my lips<br>Then our hearts beat as one<br>But you slip out of my fingertips<br>Every time you run, whoa-oh-whoa-oh-oh<br><br>Don't wanna break your heart<br>Wanna give your heart a break<br>I know you're scared it's wrong<br>Like you might make a mistake<br>There's just one life to live<br>And there's no time to wait, to wait<br>So let me give your heart a break<br><br>'Cause you've been hurt before<br>I can see it in your eyes<br>You try to smile it away<br>Some things you can't disguise<br>Don't wanna break your heart<br>Baby, I can ease the ache, the ache<br>So let me give your heart a break, give your heart a break<br>Let me give your heart a break, your heart a break<br>There's just so much you can take<br>Give your heart a break<br>Let me give your heart a break, your heart a break<br>Oh yeah, yeah<br><br>The day I first met you<br>You told me you'd never fall in love</div>",
                    UserName = "User 1"
                },
                new Song
                {
                    SongId = 6,
                    Name = "Skyscraper",
                    Slug = "skyscraper",
                    Featured = false,
                    Album = "Unbroken (2011)",
                    Lyrics = "<br><div>The day I first met you<br>You told me you'd never fall in love<br>But now that I get you<br>I know fear is what it really was<br><br>Now here we are<br>So close yet so far<br>Haven't I passed the test?<br>When will you realize<br>Baby, I'm not like the rest?<br><br>Don't wanna break your heart<br>Wanna give your heart a break<br>I know you're scared it's wrong<br>Like you might make a mistake<br>There's just one life to live<br>And there's no time to wait, to wait<br>So let me give your heart a break, give your heart a break<br>Let me give your heart a break, your heart a break<br>Oh yeah, yeah<br><br>On Sunday you went home alone<br>There were tears in your eyes<br>I called your cell phone, my love<br>But you did not reply<br><br>The world is ours. If we want it<br>We can take it if you just take my hand<br>There's no turning back now<br>Baby, try to understand<br><br>Don't wanna break your heart<br>Wanna give your heart a break<br>I know you're scared it's wrong<br>Like you might make a mistake<br>There's just one life to live<br>And there's no time to wait, to wait<br>So let me give your heart a break, give your heart a break<br>Let me give your heart a break, your heart a break<br>There's just so much you can take<br>Give your heart a break<br>Let me give your heart a break, your heart a break<br>Oh yeah, yeah<br><br>When your lips are on my lips<br>Then our hearts beat as one<br>But you slip out of my fingertips<br>Every time you run, whoa-oh-whoa-oh-oh<br><br>Don't wanna break your heart<br>Wanna give your heart a break<br>I know you're scared it's wrong<br>Like you might make a mistake<br>There's just one life to live<br>And there's no time to wait, to wait<br>So let me give your heart a break<br><br>'Cause you've been hurt before<br>I can see it in your eyes<br>You try to smile it away<br>Some things you can't disguise<br>Don't wanna break your heart<br>Baby, I can ease the ache, the ache<br>So let me give your heart a break, give your heart a break<br>Let me give your heart a break, your heart a break<br>There's just so much you can take<br>Give your heart a break<br>Let me give your heart a break, your heart a break<br>Oh yeah, yeah<br><br>The day I first met you<br>You told me you'd never fall in love</div>",
                    UserName = "User 1"
                },
                new Song
                {
                    SongId = 7,
                    Name = "Roar",
                    Slug = "roar",
                    Featured = false,
                    Album = "Prism (2013)",
                    Lyrics = "<p></p><div>I used to bite my tongue and hold my breath<br>Scared to rock the boat and make a mess<br>So I sit quietly, agree politely<br>I guess that I forgot I had a choice<br>I let you push me past the breaking point<br>I stood for nothing, so I fell for everything<br><br><i>[Pre-Chorus:]</i><br>You held me down, but I got up (HEY!)<br>Already brushing off the dust<br>You hear my voice, you hear that sound<br>Like thunder gonna shake the ground<br>You held me down, but I got up (HEY!)<br>Get ready 'cause I've had enough<br>I see it all, I see it now<br><br><i>[Chorus:]</i><br>I got the eye of the tiger, a fighter, dancing through the fire<br>'Cause I am a champion and you're gonna hear me roar<br>Louder, louder than a lion<br>'Cause I am a champion and you're gonna hear me roar<br>Oh oh oh oh oh oh oh<br>Oh oh oh oh oh oh oh<br>Oh oh oh oh oh oh oh<br>You're gonna hear me roar<br><br>Now I'm floating like a butterfly<br>Stinging like a bee I earned my stripes<br>I went from zero, to my own hero<br><br><i>[Pre-Chorus:]</i><br>You held me down, but I got up (HEY!)<br>Already brushing off the dust<br>You hear my voice, you hear that sound<br>Like thunder gonna shake the ground<br>You held me down, but I got up (HEY!)<br>Get ready 'cause I've had enough<br>I see it all, I see it now<br><br><i>[Chorus:]</i><br>I got the eye of the tiger, a fighter, dancing through the fire<br>'Cause I am a champion and you're gonna hear me roar<br>Louder, louder than a lion<br>'Cause I am a champion and you're gonna hear me roar<br>Oh oh oh oh oh oh oh<br>Oh oh oh oh oh oh oh<br>Oh oh oh oh oh oh oh<br>(You're gonna hear me roar)<br>Oh oh oh oh oh oh oh<br>Oh oh oh oh oh oh oh<br>(You'll hear me roar)<br>Oh oh oh oh oh oh oh<br>You're gonna hear me roar...<br><br>Ro-oar, ro-oar, ro-oar, ro-oar, ro-oar<br><br>I got the eye of the tiger, a fighter, dancing through the fire<br>'Cause I am a champion and you're gonna hear me roar<br>Louder, louder than a lion<br>'Cause I am a champion and you're gonna hear me roar<br>Oh oh oh oh oh oh oh<br>Oh oh oh oh oh oh oh<br>Oh oh oh oh oh oh oh<br>(You're gonna hear me roar)<br>Oh oh oh oh oh oh oh<br>Oh oh oh oh oh oh oh<br>(You'll hear me roar)<br>Oh oh oh oh oh oh oh<br>You're gonna hear me roar...</div><br><br><p></p>",
                    UserName = "User 1"
                },
                new Song
                {
                    SongId = 8,
                    Name = "Firework",
                    Slug = "firework",
                    Featured = true,
                    Album = "Teenage Dream",
                    Lyrics = "Do You Ever Feel Like A Plastic Bag<br> Drifting Through The Wind, Wanting To Start Again?<br> Do You Ever Feel, Feel So Paper-thin<br> Like A House Of Cards, One Blow From Caving In?<br> <br> Do You Ever Feel Already Buried Deep<br> Six Feet Under Screams But No One Seems To Hear A Thing<br> Do You Know That There's Still A Chance For You<br> 'Cause There's A Spark In You?<br> <br> You Just Gotta Ignite The Light And Let It Shine<br> Just Own The Night Like The 4th Of July<br> <br> 'Cause, Baby, You're A Firework<br> Come On, Show 'em What You're Worth<br> Make 'em Go, \"Ah, Ah, Ah\"<br> As You Shoot Across The Sky<br> <br> Baby, You're A Firework<br> Come On, Let Your Colors Burst<br> Make 'em Go, \"Ah, Ah, Ah\"<br> You're Gonna Leave 'em All In Awe, Awe, Awe<br> <br> You Don't Have To Feel Like A Wasted Space<br> You're Original, Cannot Be Replaced<br> If You Only Knew What The Future Holds<br> After A Hurricane Comes A Rainbow<br> <br> Maybe A Reason Why All The Doors Are Closed<br> So You Could Open One That Leads You To The Perfect Road<br> Like A Lightning Bolt Your Heart Will Glow<br> And When It's Time You'll Know<br> <br> You Just Gotta Ignite The Light And Let It Shine<br> Just Own The Night Like The 4th Of July<br> <br> 'Cause, Baby, You're A Firework<br> Come On, Show 'em What You're Worth<br> Make 'em Go, \"Ah, Ah, Ah\"<br> As You Shoot Across The Sky<br> <br> Baby, You're A Firework<br> Come On, Let Your Colors Burst<br> Make 'em Go, \"Ah, Ah, Ah\"<br> You're Gonna Leave 'em All In Awe, Awe, Awe<br> <br> Boom, Boom, Boom<br> Even Brighter Than The Moon, Moon, Moon<br> It's Always Been Inside Of You, You, You<br> And Now It's Time To Let It Through, -ough, -ough<br> <br> 'Cause, Baby, You're A Firework<br> Come On, Show 'em What You're Worth<br> Make 'em Go, \"Ah, Ah, Ah\"<br> As You Shoot Across The Sky<br> <br> Baby, You're A Firework<br> Come On, Let Your Colors Burst<br> Make 'em Go, \"Ah, Ah, Ah\"<br> You're Gonna Leave 'em All In Awe, Awe, Awe<br> <br> Boom, Boom, Boom<br> Even Brighter Than The Moon, Moon, Moon<br> Boom, Boom, Boom<br> Even Brighter Than The Moon, Moon, Moon <br>",
                    UserName = "User 1"
                },
                new Song
                {
                    SongId = 9,
                    Name = "Dark Horse",
                    Slug = "dark-horse",
                    Featured = false,
                    Album = "Prism (2013)",
                    Lyrics = "<p><b>\"Dark Horse\"</b><br>(feat. Juicy J)<br><br></p><div>Oh, no<br><br><i>[Juicy J:]</i><br>Yeah<br>Ya'll know what it is<br>Katy Perry<br>Juicy J, aha<br>Let's rage<br><br><i>[Katy Perry:]</i><br>I knew you were<br>You were gonna come to me<br>And here you are<br>But you better choose carefully<br>'Cause I, I'm capable of anything<br>Of anything and everything<br><br>Make me your Aphrodite<br>Make me your one and only<br>But don't make me your enemy, your enemy, your enemy<br><br>So you wanna play with magic<br>Boy, you should know what you're falling for<br>Baby do you dare to do this?<br>Cause I'm coming at you like a dark horse<br>Are you ready for, ready for<br>A perfect storm, perfect storm<br>Cause once you're mine, once you're mine<br>There is no going back<br><br>Mark my words<br>This love will make you levitate<br>Like a bird<br>Like a bird without a cage<br>But down to earth<br>If you choose to walk away, don't walk away<br><br>It's in the palm of your hand now baby<br>It's a yes or no, no maybe<br>So just be sure before you give it all to me<br>All to me, give it all to me<br><br>So you wanna play with magic<br>Boy, you should know what you're falling for<br>Baby do you dare to do this?<br>Cause I'm coming at you like a dark horse<br>Are you ready for, ready for<br>A perfect storm, perfect storm<br>Cause once you're mine, once you're mine (love trippin')<br>There's no going back<br><br><i>[Juicy J - Rap Verse:]</i><br>Uh<br>She's a beast<br>I call her Karma (come back)<br>She eats your heart out<br>Like Jeffrey Dahmer (woo)<br>Be careful<br>Try not to lead her on<br>Shorty's heart is on steroids<br>Cause her love is so strong<br>You may fall in love<br>When you meet her<br>If you get the chance you better keep her<br>She's sweet as pie but if you break her heart<br>She'll turn cold as a freezer<br>That fairy tale ending with a knight in shining armor<br>She can be my Sleeping Beauty<br>I'm gon' put her in a coma<br>Woo!<br>Damn I think I love her<br>Shorty so bad, I'm sprung and I don't care<br>She ride me like a roller coaster<br>Turned the bedroom into a fair (a fair!)<br>Her love is like a drug<br>I was tryna hit it and quit it<br>But lil' mama so dope<br>I messed around and got addicted<br><br><i>[Katy Perry:]</i><br>So you wanna play with magic<br>Boy, you should know what you're falling for (you should know)<br>Baby do you dare to do this?<br>Cause I'm coming at you like a dark horse (like a dark horse)<br>Are you ready for, ready for (ready for)<br>A perfect storm, perfect storm (a perfect storm)<br>Cause once you're mine, once you're mine (mine)<br>There's no going back</div><br>",
                    UserName = "User 1"
                },
                new Song
                {
                    SongId = 10,
                    Name = "Not Afraid",
                    Slug = "not-afraid",
                    Featured = true,
                    Album = "Recovery (2010)",
                    Lyrics = "I'm not afraid (I'm not afraid)<br>To take a stand (to take a stand)<br>Everybody (everybody)<br>Come take my hand (come take my hand)<br>We'll walk this road together, through the storm<br>Whatever weather, cold or warm<br>Just letting you know that you're not alone<br>Holler if you feel like you've been down the same road (same road)<br><br>Yeah, it's been a ride<br>I guess I had to, go to that place, to get to this one<br>Now some of you, might still be in that place<br>If you're trying to get out, just follow me<br>I'll get you there<br><br>You can try and read my lyrics off of this paper before I lay 'em<br>But you won't take the sting out these words before I say 'em<br>'Cause ain't no way I'mma let you stop me from causing mayhem<br>When I say I'mma do something I do it<br>I don't give a damn what you think<br>I'm doing this for me, so fuck the world<br>Feed it beans, it's gassed up, if it thinks it's stopping me<br>I'mma be what I set out to be, without a doubt undoubtedly<br>And all those who look down on me I'm tearing down your balcony<br>No ifs, ands or buts, don't try to ask him why or how can he<br>From \"Infinite\" down to the last \"Relapse\" album<br>He's still shitting, whether he's on salary paid hourly<br>Until he bows out or he shits his bowels out of him<br>Whichever comes first, for better or worse<br>He's married to the game, like a \"fuck you\" for Christmas<br>His gift is a curse, forget the Earth, he's got the urge<br>To pull his dick from the dirt, and fuck the whole universe<br><br>I'm not afraid (I'm not afraid)<br>To take a stand (to take a stand)<br>Everybody (everybody)<br>Come take my hand (come take my hand)<br>We'll walk this road together, through the storm<br>Whatever weather, cold or warm<br>Just letting you know that you're not alone<br>Holler if you feel like you've been down the same road (same road)<br><br>Okay quit playing with the scissors and shit, and cut the crap<br>I shouldn't have to rhyme these words in a rhythm for you to know it's a rap<br>You said you was king, you lied through your teeth<br>For that fuck your feelings<br>Instead of getting crowned you're getting capped<br>And to the fans, I'll never let you down again, I'm back<br>I promise to never go back on that promise<br>In fact let's be honest<br>That last \"Relapse\" CD was \"ehh\"<br>Perhaps I ran them accents into the ground<br>Relax, I ain't going back to that now<br>All I'm trying to say is get back, click-clack, blow<br>'Cause I ain't playing around<br>There's a game called circle and I don't know how, I'm way too up to back down<br>But I think I'm still trying to figure this crap out<br>Thought I had it mapped out but I guess I didn't, this fucking black cloud<br>Still follows me around but it's time to exorcise these demons<br>These motherfuckers are doing jumping jacks now!<br><br>I'm not afraid (I'm not afraid)<br>To take a stand (to take a stand)<br>Everybody (everybody)<br>Come take my hand (come take my hand)<br>We'll walk this road together, through the storm<br>Whatever weather, cold or warm<br>Just letting you know that you're not alone<br>Holler if you feel like you've been down the same road (same road)<br><br>And I just can't keep living this way<br>So starting today, I'm breaking out of this cage<br>I'm standing up, I'mma face my demons<br>I'm manning up, I'mma hold my ground<br>I've had enough, now I'm so fed up<br>Time to put my life back together right now! (now)<br><br>It was my decision to get clean, I did it for me<br>Admittedly, I probably did it subliminally<br>For you, so I could come back a brand-new me you helped see me through<br>And don't even realize what you did, 'cause believe me you<br>I've been through the wringer, but they could do little to the middle finger<br>I think I got a tear in my eye, I feel like the king of<br>My world, haters can make like bees with no stingers<br>And drop dead, no more beef lingers<br>No more drama from now on, I wanna promise<br>To focus solely on handling my responsibilities as a father<br>So I solemnly swear to always treat this roof, like my daughters<br>And raise it, you couldn't lift a single shingle on it!<br>'Cause the way I feel, I'm strong enough to go to the club<br>Or the corner pub, and lift the whole liquor counter up<br>'Cause I'm raising the bar<br>I'd shoot for the moon but I'm too busy gazing at stars<br>I feel amazing and I'm...<br><br>I'm not afraid (I'm not afraid)<br>To take a stand (to take a stand)<br>Everybody (everybody)<br>Come take my hand (come take my hand)<br>We'll walk this road together, through the storm<br>Whatever weather, cold or warm<br>Just letting you know that you're not alone<br>Holler if you feel like you've been down the same road (same road)",
                    UserName = "User 1"
                },
                new Song
                {
                    SongId = 11,
                    Name = "Mockingbird",
                    Slug = "mockingbird",
                    Featured = false,
                    Album = "Curtain Call: The Hits (2005)",
                    Lyrics = "Yeah<br>I know sometimes things may not always make sense to you right now<br>But hey, what daddy always tell you?<br>Straighten up little soldier<br>Stiffen up that upper lip<br>What you crying about?<br>You got me.<br><br>Hailie, I know you miss your mom, and I know you miss your dad<br>When I'm gone but I'm trying to give you the life that I never had<br>I can see you're sad, even when you smile, even when you laugh<br>I can see it in your eyes, deep inside you want to cry<br>'Cause you're scared, I ain't there?<br>Daddy's with you in your prayers<br>No more crying, wipe them tears<br>Daddy's here, no more nightmares<br>We gon' pull together through it, we gon' do it<br>Lainie Uncle's crazy, ain't he?<br>Yeah, but he loves you girl and you better know it<br>We're all we got in this world<br>When it spins, when it swirls<br>When it whirls, when it twirls<br>Two little beautiful girls<br>Lookin' puzzled, in a daze<br>I know it's confusing you<br>Daddy's always on the move, mamma's always on the news<br>I try to keep you sheltered from it but somehow it seems<br>The harder that I try to do that, the more it backfires on me<br>All the things growing up as daddy, that he had to see<br>Daddy don't want you to see but you see just as much as he did<br>We did not plan it to be this way, your mother and me<br>But things have got so bad between us<br>I don't see us ever being together ever again<br>Like we used to be when we was teenagers<br>But then of course everything always happens for a reason<br>I guess it was never meant to be<br>But it's just something we have no control over and that's what destiny is<br>But no more worries, rest your head and go to sleep<br>Maybe one day we'll wake up and this will all just be a dream<br><br>Now hush little baby, don't you cry<br>Everything's gonna be alright<br>Stiffen that upper lip up, little lady, I told ya<br>Daddy's here to hold ya through the night<br>I know mommy's not here right now and we don't know why<br>We fear how we feel inside<br>It may seem a little crazy, pretty baby<br>But I promise mama's gon' be alright<br><br>(Ha)<br>It's funny<br>I remember back one year when daddy had no money<br>Mommy wrapped the Christmas presents up<br>And stuck 'em under the tree and said some of 'em were from me<br>'Cause daddy couldn't buy 'em<br>I'll never forget that Christmas I sat up the whole night crying<br>'Cause daddy felt like a bum, see daddy had a job<br>But his job was to keep the food on the table for you and mom<br>And at the time every house that we lived in<br>Either kept getting broken into and robbed<br>Or shot up on the block and your mom was saving money for you in a jar<br>Tryna start a piggy bank for you so you could go to college<br>Almost had a thousand dollars 'til someone broke in and stole it<br>And I know it hurts so bad it broke your mamma's heart<br>And it seemed like everything was just startin' to fall apart<br>Mom and dad was arguin' a lot so momma moved back<br>On the Chalmers in the flat one bedroom apartment<br>And dad moved back to the other side of 8 Mile on Novara<br>And that's when daddy went to California with his CD and met Dr. Dre<br>And flew you and momma out to see me<br>But daddy had to work, you and momma had to leave me<br>Then you started seeing daddy on the T.V. and momma didn't like it<br>And you and Lainnie were too young to understand it<br>Papa was a rollin' stone, momma developed a habit<br>And it all happened too fast for either one of us to grab it<br>I'm just sorry you were there and had to witness it first hand<br>'Cause all I ever wanted to do was just make you proud<br>Now I'm sitting in this empty house, just reminiscing<br>Lookin' at your baby pictures, it just trips me out<br>To see how much you both have grown, it's almost like you're sisters now<br>Wow, I guess you pretty much are and daddy's still here<br>Lainnie I'm talkin' to you too, daddy's still here<br>I like the sound of that, yeah<br>It's got a ring to it don't it?<br>Shh, mama's only gone for the moment<br><br>Now hush little baby, don't you cry<br>Everything's gonna be alright<br>Stiffen that upper lip up, little lady, I told ya<br>Daddy's here to hold ya through the night<br>I know mommy's not here right now and we don't know why<br>We fear how we feel inside<br>It may seem a little crazy, pretty baby<br>But I promise mama's gon' be alright<br><br>And if you ask me to<br>Daddy's gonna buy you a mockingbird<br>I'mma give you the world<br>I'mma buy a diamond ring for you<br>I'mma sing for you<br>I'll do anything for you to see you smile<br>And if that mockingbird don't sing and that ring don't shine<br>I'mma break that birdie's neck<br>I'll go back to the jeweler who sold it to ya<br>And make him eat every carat don't fuck with dad (ha ha)",
                    UserName = "User 1"
                },
                new Song
                {
                    SongId = 12,
                    Name = "Lose Yourself",
                    Slug = "lose-yourself",
                    Featured = false,
                    Album = "Curtain Call: The Hits (2005)",
                    Lyrics = "<br><div>Look, if you had one shot, or one opportunity<br>To seize everything you ever wanted, in one moment<br>Would you capture it, or just let it slip?<br><br>Yo! His palms are sweaty, knees weak, arms are heavy<br>There's vomit on his sweater already: Mom's spaghetti<br>He's nervous, but on the surface he looks calm and ready<br>To drop bombs, but he keeps on forgetting<br>What he wrote down, the whole crowd goes so loud<br>He opens his mouth, but the words won't come out<br>He's choking, how? Everybody's joking now<br>The clock's run out, time's up, over, blaow!<br>Snap back to reality, ope there goes gravity, ope<br>There goes Rabbit, he choked, he's so mad but he won't<br>Give up that easy, no, he won't have it, he knows<br>His whole back's to these ropes, it don't matter, he's dope<br>He knows that but he's broke, he's so stagnant, he knows<br>When he goes back to this mobile home, that's when it's<br>Back to the lab again yo, this whole rhapsody<br>Better go capture this moment and hope it don't pass him, and<br><br>You better lose yourself in the music<br>The moment, you own it, you better never let it go<br>You only get one shot, do not miss your chance to blow<br>This opportunity comes once in a lifetime, yo<br>You better lose yourself in the music<br>The moment, you own it, you better never let it go<br>You only get one shot, do not miss your chance to blow<br>This opportunity comes once in a lifetime, yo<br>You better…<br><br>His soul's escaping through this hole that is gaping<br>This world is mine for the taking, make me king<br>As we move toward a New World Order<br>A normal life is boring; but superstardom's<br>Close to post-mortem, it only grows harder<br>Homie grows hotter, he blows, it's all over<br>These hoes is all on him, coast-to-coast shows<br>He's known as the Globetrotter, lonely roads<br>God only knows, he's grown farther from home, he's no father<br>He goes home and barely knows his own daughter<br>But hold your nose, 'cause here goes the cold water<br>These hoes don't want him no mo', he's cold product<br>They moved on to the next schmoe who flows<br>He nose-dove and sold nada, and so the soap opera<br>Is told, it unfolds, I suppose it's old, partner<br>But the beat goes on: da da dum da dum da da da da<br><br>You better lose yourself in the music<br>The moment, you own it, you better never let it go<br>You only get one shot, do not miss your chance to blow<br>This opportunity comes once in a lifetime, yo<br>You better lose yourself in the music<br>The moment, you own it, you better never let it go<br>You only get one shot, do not miss your chance to blow<br>This opportunity comes once in a lifetime, yo<br>You better…<br><br>No more games, I'ma change what you call rage<br>Tear this motherfuckin' roof off like two dogs caged<br>I was playin' in the beginning, the mood all changed<br>I've been chewed up and spit out and booed off stage<br>But I kept rhymin' and stepped right in the next cypher<br>Best believe somebody's payin' the Pied Piper<br>All the pain inside amplified by the<br>Fact that I can't get by with my 9-to-5<br>And I can't provide the right type of life for my family<br>'Cause man, these goddamn food stamps don't buy diapers<br>And there's no movie, there's no Mekhi Phifer, this is my life<br>And these times are so hard, and it's gettin' even harder<br>Tryna feed and water my seed, plus teeter-totter<br>Caught up between bein' a father and a prima donna<br>Baby mama drama, screamin' on her, too much for me to wanna<br>Stay in one spot, another day of monotony's<br>Gotten me to the point I'm like a snail, I've got<br>To formulate a plot or end up in jail or shot<br>Success is my only motherfuckin' option, failure's not<br>Mom, I love you, but this trailer's got<br>To go; I cannot grow old in Salem's Lot<br>So here I go, it's my shot: feet, fail me not<br>This may be the only opportunity that I got<br><br>You better lose yourself in the music<br>The moment, you own it, you better never let it go (go)<br>You only get one shot, do not miss your chance to blow<br>This opportunity comes once in a lifetime, yo<br>You better lose yourself in the music<br>The moment, you own it, you better never let it go (go)<br>You only get one shot, do not miss your chance to blow<br>This opportunity comes once in a lifetime, yo<br>You better…<br><br>You can do anything you set your mind to, man</div>",
                    UserName = "User 1"
                },
                new Song
                {
                    SongId = 13,
                    Name = "Candy Shop",
                    Slug = "candy-shop",
                    Featured = true,
                    Album = "The Massacre (2005)",
                    Lyrics = "<i>[Intro: 50 Cent]</i><br>Yeah...<br>Uh huh<br>So seductive<br><br><i>[Chorus: 50 Cent &amp; Olivia]</i><br><i>[50 Cent]</i><br>I'll take you to the candy shop<br>I'll let you lick the lollipop<br>Go 'head girl, don't you stop<br>Keep going 'til you hit the spot (woah)<br><i>[Olivia]</i><br>I'll take you to the candy shop<br>Boy one taste of what I got<br>I'll have you spending all you got<br>Keep going 'til you hit the spot (woah)<br><br><i>[Verse 1: 50 Cent]</i><br>You can have it your way, how do you want it<br>You gon' back that thing up or should i push up on it<br>Temperature rising, okay lets go to the next level<br>Dance floor jam packed, hot as a teakettle<br>I'll break it down for you now, baby it's simple<br>If you be a nympho, I'll be a nympho<br>In the hotel or in the back of the rental<br>On the beach or in the park, it's whatever you into<br>Got the magic stick, I'm the love doctor<br>Have your friends teasing you 'bout how sprung I gotcha<br>Wanna show me how you work it baby, no problem<br>Get on top then get to bouncing round like a low rider<br>I'm a seasons vet when it come to this shit<br>After you work up a sweat you can play with the stick<br>I'm trying to explain baby the best way I can<br>I melt in your mouth girl, not in your hands (ha ha)<br><br><i>[Chorus]</i><br><br><i>[Bridge: 50 Cent &amp; Olivia]</i><br>Girl what we do (what we do)<br>And where we do (and where we do)<br>The things we do (things we do)<br>Are just between me and you (oh yeah)<br><br><i>[Verse 2: 50 Cent]</i><br>Give it to me baby, nice and slow<br>Climb on top, ride like you in the rodeo<br>You ain't never heard a sound like this before<br>Cause I ain't never put it down like this before<br>Soon as I come through the door she get to pulling on my zipper<br>It's like it's a race who can get undressed quicker<br>Isn't it ironic how erotic it is to watch em in thongs<br>Had me thinking 'bout that ass after I'm gone<br>I touch the right spot at the right time<br>Lights on or lights off, she like it from behind<br>So seductive, you should see the way she wind<br>Her hips in slow-mo on the floor when we grind<br>As Long as she ain't stopping, homie I ain't stopping<br>Dripping wet with sweat man its on and popping<br>All my champagne campaign, bottle after bottle its on<br>And we gon' sip 'til every bubble in every bottle is gone<br><br><i>[Chorus 2x]</i>",
                    UserName = "User 1"
                },
                new Song
                {
                    SongId = 14,
                    Name = "Corazon",
                    Slug = "corazon",
                    Featured = true,
                    Album = "Ceinture Noire (2018)",
                    Lyrics = "<div>Corazón<br><br>Corazón, dis-moi pourquoi tu fuis ; pour toi, qu'est-ce que je suis ?<br>Mi corazón, dis-moi combien tu m'aimes, dis-moi ce que j'ai fait<br>Mi corazón, dis-moi où est-ce que tu vas, non, non, ne t'en va pas<br>Mi corazón, corazón, corazón<br><br>J'ai pas la prétention de te demander ta main<br>J'ai vu ton visage apparaître dans les flammes<br>J'préfère encore te contempler tout comme un gamin<br>Car tu es l'esprit du Malin<br>Avec toi, impossible de savoir à quoi s'attendre<br>Tu changes de peau, tu glisses dans des draps de satin<br>J'aurais préféré ne jamais croiser ton chemin<br>Oooh<br><br>(Corazón) Un jour, tu me dis des mots doux, tu m'fais savoir qu'on est intime<br>(Corazón) Un jour, tu me laisse dans le doute et tu fais de moi ton ennemi<br>(Corazón) Je n'sais plus à quoi m'attendre, dis-moi c'que je n'ai pas compris<br>(Corazón) Accorde-moi de ton temps, je ne t'ai demandé qu'une nuit<br><br>Corazón, dis-moi pourquoi tu fuis ; pour toi, qu'est-ce que je suis ?<br>Mi corazón, dis-moi combien tu m'aimes, dis-moi ce que j'ai fait<br>Mi corazón, dis-moi où est-ce que tu vas, non, non, ne t'en va pas<br>Mi corazón, corazón, corazón<br><br>On m'a dit que tu dévorais tous les hommes<br>Et, d'après la rumeur, tu ne souris jamais<br>Tu prendras tout de moi, tu m'laisseras seul, enchaîné<br>Est-ce que j'ai tort ? Non, je savais<br>J'avance vers toi, les courbes de ton corps m’assomment<br>Tu diras : \"J'ai récolté tout ce que j'ai semé\"<br>Attends deux minutes, j'ai déjà vécu la scène<br><br>(Corazón) Un jour, tu me dis des mots doux, tu m'fais savoir qu'on est intime<br>(Corazón) Un jour, tu me laisse dans le doute et tu fais de moi ton ennemi<br>(Corazón) Je n'sais plus à quoi m'attendre, dis-moi c'que je n'ai pas compris<br>(Corazón) Accorde-moi de ton temps, je ne t'ai demandé qu'une nuit<br><br>Corazón, dis-moi pourquoi tu fuis ; pour toi, qu'est-ce que je suis ?<br>Mi corazón, dis-moi combien tu m'aimes, dis-moi ce que j'ai fait<br>Mi corazón, dis-moi où est-ce que tu vas, non, non, ne t'en va pas<br>Mi corazón, corazón, corazón<br><br>Et tu es rentrée dans ma tête, ce jour-là, comme une maladie<br>Et, ce que tu m'as dit, je l'ai en mélodie<br>Et tu es rentrée dans ma tête, ce jour-là, comme une maladie<br>Et, ce que tu m'as dit, je l'ai en mélodie<br>Et tu es rentrée dans ma tête, ce jour-là, comme une maladie<br>Et, ce que tu m'as dit, je l'ai en mélodie<br>Et tu es rentrée dans ma tête, ce jour-là, comme une maladie<br>Et, ce que tu m'as dit, je l'ai en mélodie<br><br>Corazón, dis-moi pourquoi tu fuis ; pour toi, qu'est-ce que je suis ?<br>Mi corazón, dis-moi combien tu m'aimes, dis-moi ce que j'ai fait<br>Mi corazón, dis-moi où est-ce que tu vas, non, non, ne t'en va pas<br>Mi corazón, corazón<br>Corazón, dis-moi pourquoi tu fuis ; pour toi, qu'est-ce que je suis ?<br>Mi corazón, dis-moi combien tu m'aimes, dis-moi ce que j'ai fait<br>Mi corazón, dis-moi où est-ce que tu vas, non, non, ne t'en va pas<br>Mi corazón, corazón, corazón<br><br>Corazón<br>Corazón<br>Corazón</div>",
                    UserName = "User 1"
                },
                new Song
                {
                    SongId = 15,
                    Name = "Lule Lule  (Feat. Lumi B)",
                    Slug = "lule-lule",
                    Featured = true,
                    Album = "No Album",
                    Lyrics = "<br><div></div><div><p>[Dafina:]<br>You got me up all night.<br>me lotë n'sy une tash<br>po t'lutna me'u kthy prap,<br>ti nuk ktheh'sh m'rapsht.<br>You got me up all night.<br>You got me up all night.<br>me pas edhe nji rastë,<br>unë me ty me u kan bashkë.<br><br>[REF.:]<br>E lule-lule, e lule-lule,<br>unë për ty t'gjitha ti jap.<br>e ndalu pak, e ndalu pak,<br>se zemra ime je ti vetem.<br>E lule-lu, e lule-lu<br>E lule-lule, maca-maca<br>Se unë për ty, se unë për ty<br>Unë për ty veç ndaloj pak.<br>E lule-lu, e lule-lu<br>e lule-lule-lule-lule-lule-lu<br>E lule-lu, e lule-lu<br>e lule-lule-lule-lule-lule-lu<br><br>[Lumi:]<br>Po get u kon e shkrume<br>K'to sene s'kan t'pagume<br>Je munu me ik amo prap..<br>Ti je kthy te une<br>Gjeste t'pa menume<br>Ç'a ka ndodh dje e harrume<br>Sot e kalume<br>Deren e ki qel<br>Edhe krevetin me lule<br><br>[Dafina:]<br>E lule lule...<br><br>[Lumi:]<br>Prap ma ngule<br><br>[Dafina:]<br>E lule lulee<br><br>[Lumi:]<br>Prap ma ngule<br><br>[Dafina:]<br>Sa t'kom daaaasht<br><br>[Lumi:]<br>Me and my girl për jetë<br>All eyes on us, na s'i kqyrim tjert<br>Moj e bukura more<br>Ma e bukura ti je<br>K'si dashnie ka veq njëherë n'jetë.<br>...<br><br>[Dafina:]<br>E lule-lu, e lule-lu<br>E lule-lule, maca-maca<br>Se une per ty, se une per ty<br>Une per ty veç ndaloj pak<br>E lule-lu, e lule-lu<br>e lule-lule-lule-lule-lule-lu<br>E lule-lu, e lule-lu<br>e lule-lule-lule-lule-lule-lu</p></div>",
                    UserName = "User 1"
                },
                new Song
                {
                    SongId = 16,
                    Name = "Vuj Vuj Vuj",
                    Slug = "vuj-vuj-vuj",
                    Featured = false,
                    Album = "No Album",
                    Lyrics = "E di që une faj kom<br>pe di që je ka vajton<br>jena dosta po nuk mjafton<br>i need good lovin s'je ka m'kupton<br>2x<br><br>tash ti vuj vuj vuj<br>Mi kqyr story't edhe luj luj luj<br>zemra dhem dhem luj luj luj<br>e di që t'vjen edhe vuj vuj vuj<br>2x<br><br>N'lidhje<br>e di pa faj je<br>1 m'fal prej meje<br>si lan 1 mal me dhimbje<br><br>E di që une faj kom<br>pe di që je ka vajton<br>jena dosta po nuk mjafton<br>i need good lovin sje ka m'kupton<br>2x<br><br>n'mendimet e tua<br>ti hala smunesh me m'nshu<br>buzet e tua..<br>qe u kry smunen me pranu<br><br>a munesh me m'ngu veç pak<br>se s'du me t'lendu un prap<br>un s'du me hap<br>s'du me hap mo asnjë plage<br><br>tash ti vuj vuj vuj<br>mi kqyr story't edhe luj luj luj<br>zemra dhem dhem luj luj luj<br>e di që t'vjen edhe vuj vuj vuj x2<br><br>Ça du prej teje<br>hek dore prej meje<br>un pi vetes smuj<br>t'lutna leje<br>mos thuj<br>un i joti jam<br>un i joti jam<br>veten e lendon<br>mu jo sun em ndrron<br>i jemi je<br>edhe nëse s'je<br><br>E di që une faj kom<br>pe di që je ka vajton<br>jena dosta po nuk mjafton<br>i need good lovin sje ka m'kupton<br><br>Vuj vuj vuj<br>Luj luj luj<br>2x<br><br>Tash ti vuj vuj vuj<br>mi kqyr story't edhe luj luj luj<br>zemra dhem dhem luj luj luj<br>e di qe t'vjen edhe vuj vuj vuj",
                    UserName = "User 1"
                }
            );
            modelBuilder.Entity<Genre>().HasData(
                new Genre()
                {
                    GenreId = 1,
                    Name = "POP",
                    Slug = "pop",
                    Info = "Info"
                },
                new Genre()
                {
                    GenreId = 2,
                    Name = "Rock",
                    Slug = "rock",
                    Info = "Info"
                },
                new Genre()
                {
                    GenreId = 3,
                    Name = "Country",
                    Slug = "country",
                    Info = "Info"
                },
                new Genre()
                {
                    GenreId = 4,
                    Name = "Folk",
                    Slug = "folk",
                    Info = "Info"
                },
                new Genre()
                {
                    GenreId = 5,
                    Name = "Hip-Hop/Rap",
                    Slug = "hip-hop-rap",
                    Info = "Info"
                },
                new Genre()
                {
                    GenreId = 6,
                    Name = "Hip-Hop",
                    Slug = "hip-hop",
                    Info = "Info"
                },
                new Genre()
                {
                    GenreId = 7,
                    Name = "Dance",
                    Slug = "dance",
                    Info = "Info"
                },
                new Genre()
                {
                    GenreId = 8,
                    Name = "Soundtrack",
                    Slug = "soundtrack",
                    Info = "Info"
                },
                new Genre()
                {
                    GenreId = 9,
                    Name = "Other",
                    Slug = "other",
                    Info = "Info"
                }
            );

            modelBuilder.Entity<Artist_Song>().HasData(
                new Artist_Song() { Id = 1, ArtistId = 1, SongId = 1 },
                new Artist_Song() { Id = 2, ArtistId = 1, SongId = 2 },
                new Artist_Song() { Id = 3, ArtistId = 1, SongId = 3 },
                new Artist_Song() { Id = 4, ArtistId = 2, SongId = 4 },
                new Artist_Song() { Id = 5, ArtistId = 2, SongId = 5 },
                new Artist_Song() { Id = 6, ArtistId = 2, SongId = 6 },
                new Artist_Song() { Id = 7, ArtistId = 3, SongId = 7 },
                new Artist_Song() { Id = 8, ArtistId = 3, SongId = 8 },
                new Artist_Song() { Id = 9, ArtistId = 3, SongId = 9 },
                new Artist_Song() { Id = 10, ArtistId = 4, SongId = 10 },
                new Artist_Song() { Id = 11, ArtistId = 4, SongId = 11 },
                new Artist_Song() { Id = 12, ArtistId = 4, SongId = 12 },
                new Artist_Song() { Id = 13, ArtistId = 5, SongId = 13 },
                new Artist_Song() { Id = 14, ArtistId = 6, SongId = 14 },
                new Artist_Song() { Id = 15, ArtistId = 7, SongId = 15 },
                new Artist_Song() { Id = 16, ArtistId = 7, SongId = 16 }
            );

            modelBuilder.Entity<Artist_Genre>().HasData(
                new Artist_Genre() { Id = 1, ArtistId = 1, GenreId = 1, CreatedAt = now, LastUpdatedAt = now },
                new Artist_Genre() { Id = 2, ArtistId = 1, GenreId = 2, CreatedAt = now, LastUpdatedAt = now },
                new Artist_Genre() { Id = 3, ArtistId = 2, GenreId = 2, CreatedAt = now, LastUpdatedAt = now },
                new Artist_Genre() { Id = 4, ArtistId = 3, GenreId = 2, CreatedAt = now, LastUpdatedAt = now },
                new Artist_Genre() { Id = 5, ArtistId = 3, GenreId = 3, CreatedAt = now, LastUpdatedAt = now },
                new Artist_Genre() { Id = 6, ArtistId = 4, GenreId = 5, CreatedAt = now, LastUpdatedAt = now },
                new Artist_Genre() { Id = 7, ArtistId = 4, GenreId = 6, CreatedAt = now, LastUpdatedAt = now },
                new Artist_Genre() { Id = 8, ArtistId = 5, GenreId = 5, CreatedAt = now, LastUpdatedAt = now },
                new Artist_Genre() { Id = 9, ArtistId = 5, GenreId = 6, CreatedAt = now, LastUpdatedAt = now },
                new Artist_Genre() { Id = 10, ArtistId = 6, GenreId = 5, CreatedAt = now, LastUpdatedAt = now },
                new Artist_Genre() { Id = 11, ArtistId = 6, GenreId = 6, CreatedAt = now, LastUpdatedAt = now },
                new Artist_Genre() { Id = 12, ArtistId = 7, GenreId = 9, CreatedAt = now, LastUpdatedAt = now }
            );

            modelBuilder.Entity<Song_Genre>().HasData(
                new Song_Genre() { Id = 1, SongId = 1, GenreId = 1, CreatedAt = now, LastUpdatedAt = now },
                new Song_Genre() { Id = 2, SongId = 1, GenreId = 6, CreatedAt = now, LastUpdatedAt = now },
                new Song_Genre() { Id = 3, SongId = 2, GenreId = 6, CreatedAt = now, LastUpdatedAt = now },
                new Song_Genre() { Id = 4, SongId = 3, GenreId = 9, CreatedAt = now, LastUpdatedAt = now },
                new Song_Genre() { Id = 5, SongId = 4, GenreId = 6, CreatedAt = now, LastUpdatedAt = now },
                new Song_Genre() { Id = 6, SongId = 4, GenreId = 8, CreatedAt = now, LastUpdatedAt = now },
                new Song_Genre() { Id = 7, SongId = 5, GenreId = 2, CreatedAt = now, LastUpdatedAt = now },
                new Song_Genre() { Id = 8, SongId = 5, GenreId = 4, CreatedAt = now, LastUpdatedAt = now },
                new Song_Genre() { Id = 9, SongId = 6, GenreId = 1, CreatedAt = now, LastUpdatedAt = now },
                new Song_Genre() { Id = 10, SongId = 6, GenreId = 4, CreatedAt = now, LastUpdatedAt = now },
                new Song_Genre() { Id = 11, SongId = 7, GenreId = 2, CreatedAt = now, LastUpdatedAt = now },
                new Song_Genre() { Id = 12, SongId = 7, GenreId = 4, CreatedAt = now, LastUpdatedAt = now },
                new Song_Genre() { Id = 13, SongId = 8, GenreId = 6, CreatedAt = now, LastUpdatedAt = now },
                new Song_Genre() { Id = 14, SongId = 8, GenreId = 7, CreatedAt = now, LastUpdatedAt = now },
                new Song_Genre() { Id = 15, SongId = 9, GenreId = 2, CreatedAt = now, LastUpdatedAt = now },
                new Song_Genre() { Id = 16, SongId = 9, GenreId = 3, CreatedAt = now, LastUpdatedAt = now },
                new Song_Genre() { Id = 17, SongId = 10, GenreId = 5, CreatedAt = now, LastUpdatedAt = now },
                new Song_Genre() { Id = 18, SongId = 10, GenreId = 6, CreatedAt = now, LastUpdatedAt = now },
                new Song_Genre() { Id = 19, SongId = 11, GenreId = 5, CreatedAt = now, LastUpdatedAt = now },
                new Song_Genre() { Id = 20, SongId = 11, GenreId = 6, CreatedAt = now, LastUpdatedAt = now },
                new Song_Genre() { Id = 21, SongId = 12, GenreId = 5, CreatedAt = now, LastUpdatedAt = now },
                new Song_Genre() { Id = 22, SongId = 12, GenreId = 6, CreatedAt = now, LastUpdatedAt = now },
                new Song_Genre() { Id = 23, SongId = 13, GenreId = 5, CreatedAt = now, LastUpdatedAt = now },
                new Song_Genre() { Id = 24, SongId = 13, GenreId = 6, CreatedAt = now, LastUpdatedAt = now },
                new Song_Genre() { Id = 25, SongId = 14, GenreId = 6, CreatedAt = now, LastUpdatedAt = now },
                new Song_Genre() { Id = 26, SongId = 15, GenreId = 7, CreatedAt = now, LastUpdatedAt = now },
                new Song_Genre() { Id = 27, SongId = 16, GenreId = 7, CreatedAt = now, LastUpdatedAt = now }
            );
        }
    }
}
