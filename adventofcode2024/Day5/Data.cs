﻿namespace adventofcode2024.Day5;

public static class Data
{
    public static readonly string testData = "47|53\n97|13\n97|61\n97|47\n75|29\n61|13\n75|53\n29|13\n97|29\n53|29\n61|53\n97|53\n61|29\n47|13\n75|47\n97|75\n47|61\n75|61\n47|29\n75|13\n53|13\n\n75,47,61,53,29\n97,61,53,29,13\n75,29,13\n75,97,47,61,53\n61,13,29\n97,13,75,29,47";
    public static readonly string trialData = "96|15\n69|95\n69|66\n41|61\n41|26\n41|28\n66|75\n66|96\n66|99\n66|95\n25|74\n25|89\n25|48\n25|61\n25|75\n11|74\n11|26\n11|51\n11|82\n11|95\n11|61\n17|58\n17|63\n17|41\n17|39\n17|62\n17|64\n17|46\n63|25\n63|27\n63|46\n63|24\n63|12\n63|53\n63|11\n63|52\n72|24\n72|11\n72|23\n72|85\n72|61\n72|82\n72|53\n72|36\n72|95\n61|74\n61|83\n61|91\n61|93\n61|87\n61|52\n61|69\n61|51\n61|42\n61|27\n19|36\n19|89\n19|75\n19|85\n19|25\n19|28\n19|65\n19|52\n19|41\n19|46\n19|64\n39|23\n39|96\n39|64\n39|12\n39|82\n39|15\n39|95\n39|99\n39|85\n39|36\n39|25\n39|61\n58|25\n58|63\n58|65\n58|23\n58|95\n58|39\n58|36\n58|64\n58|22\n58|82\n58|72\n58|75\n58|89\n75|74\n75|87\n75|61\n75|89\n75|99\n75|18\n75|53\n75|11\n75|88\n75|48\n75|28\n75|82\n75|91\n75|51\n89|69\n89|26\n89|24\n89|87\n89|74\n89|52\n89|67\n89|17\n89|91\n89|86\n89|27\n89|85\n89|93\n89|88\n89|62\n36|53\n36|67\n36|92\n36|93\n36|82\n36|85\n36|28\n36|18\n36|91\n36|74\n36|52\n36|24\n36|42\n36|87\n36|26\n36|86\n27|17\n27|91\n27|69\n27|48\n27|66\n27|34\n27|83\n27|19\n27|26\n27|22\n27|96\n27|93\n27|18\n27|72\n27|67\n27|15\n27|39\n91|72\n91|46\n91|41\n91|17\n91|66\n91|63\n91|39\n91|93\n91|15\n91|96\n91|34\n91|12\n91|83\n91|69\n91|42\n91|58\n91|22\n91|62\n15|63\n15|65\n15|85\n15|82\n15|36\n15|75\n15|88\n15|61\n15|95\n15|52\n15|28\n15|74\n15|11\n15|12\n15|46\n15|53\n15|41\n15|23\n15|87\n93|46\n93|41\n93|25\n93|75\n93|72\n93|66\n93|99\n93|12\n93|58\n93|22\n93|17\n93|15\n93|39\n93|65\n93|63\n93|62\n93|79\n93|11\n93|64\n93|95\n28|51\n28|72\n28|22\n28|91\n28|17\n28|26\n28|79\n28|18\n28|62\n28|34\n28|67\n28|69\n28|93\n28|58\n28|39\n28|48\n28|74\n28|87\n28|86\n28|42\n28|92\n67|91\n67|41\n67|17\n67|12\n67|79\n67|58\n67|96\n67|72\n67|63\n67|65\n67|42\n67|46\n67|39\n67|86\n67|25\n67|93\n67|22\n67|62\n67|69\n67|66\n67|34\n67|83\n23|34\n23|93\n23|82\n23|24\n23|87\n23|69\n23|83\n23|18\n23|67\n23|85\n23|26\n23|52\n23|88\n23|51\n23|89\n23|61\n23|48\n23|53\n23|36\n23|28\n23|27\n23|92\n23|74\n26|34\n26|66\n26|93\n26|96\n26|63\n26|62\n26|65\n26|22\n26|67\n26|69\n26|12\n26|17\n26|15\n26|48\n26|91\n26|39\n26|86\n26|19\n26|51\n26|83\n26|72\n26|42\n26|79\n26|58\n12|23\n12|82\n12|11\n12|27\n12|46\n12|25\n12|92\n12|61\n12|18\n12|85\n12|75\n12|53\n12|52\n12|89\n12|41\n12|88\n12|87\n12|74\n12|99\n12|95\n12|36\n12|64\n12|24\n12|28\n24|52\n24|18\n24|53\n24|42\n24|92\n24|48\n24|66\n24|58\n24|88\n24|62\n24|93\n24|69\n24|27\n24|91\n24|67\n24|34\n24|51\n24|74\n24|17\n24|83\n24|26\n24|87\n24|28\n24|86\n62|79\n62|58\n62|96\n62|41\n62|22\n62|11\n62|15\n62|65\n62|36\n62|75\n62|64\n62|82\n62|99\n62|95\n62|66\n62|46\n62|72\n62|23\n62|12\n62|61\n62|19\n62|39\n62|63\n62|25\n48|65\n48|39\n48|93\n48|15\n48|62\n48|67\n48|51\n48|19\n48|79\n48|42\n48|66\n48|96\n48|17\n48|72\n48|91\n48|34\n48|41\n48|86\n48|22\n48|58\n48|63\n48|69\n48|12\n48|83\n85|74\n85|42\n85|17\n85|26\n85|91\n85|53\n85|67\n85|87\n85|88\n85|62\n85|51\n85|58\n85|83\n85|69\n85|24\n85|52\n85|34\n85|27\n85|28\n85|92\n85|48\n85|86\n85|18\n85|93\n83|15\n83|72\n83|66\n83|86\n83|62\n83|65\n83|17\n83|79\n83|58\n83|64\n83|22\n83|12\n83|11\n83|39\n83|25\n83|63\n83|41\n83|96\n83|42\n83|69\n83|75\n83|46\n83|19\n83|93\n64|75\n64|26\n64|48\n64|27\n64|51\n64|87\n64|74\n64|92\n64|95\n64|85\n64|18\n64|52\n64|82\n64|11\n64|61\n64|28\n64|53\n64|23\n64|36\n64|88\n64|24\n64|89\n64|67\n64|99\n99|83\n99|82\n99|18\n99|91\n99|53\n99|89\n99|48\n99|27\n99|69\n99|24\n99|88\n99|74\n99|52\n99|28\n99|36\n99|34\n99|92\n99|23\n99|85\n99|87\n99|61\n99|67\n99|26\n99|51\n42|17\n42|65\n42|72\n42|63\n42|15\n42|12\n42|99\n42|66\n42|75\n42|62\n42|22\n42|95\n42|19\n42|58\n42|46\n42|11\n42|96\n42|39\n42|23\n42|25\n42|86\n42|64\n42|79\n42|41\n51|69\n51|58\n51|79\n51|25\n51|63\n51|17\n51|65\n51|67\n51|41\n51|39\n51|19\n51|62\n51|93\n51|12\n51|83\n51|86\n51|42\n51|91\n51|34\n51|66\n51|15\n51|72\n51|22\n51|96\n87|58\n87|51\n87|96\n87|42\n87|93\n87|83\n87|19\n87|17\n87|72\n87|48\n87|22\n87|79\n87|39\n87|67\n87|62\n87|86\n87|92\n87|27\n87|34\n87|69\n87|66\n87|91\n87|18\n87|26\n46|87\n46|64\n46|28\n46|74\n46|24\n46|26\n46|27\n46|85\n46|61\n46|48\n46|18\n46|95\n46|89\n46|88\n46|36\n46|92\n46|23\n46|75\n46|11\n46|82\n46|53\n46|52\n46|51\n46|99\n22|95\n22|41\n22|99\n22|63\n22|61\n22|15\n22|39\n22|82\n22|85\n22|96\n22|64\n22|23\n22|11\n22|65\n22|46\n22|12\n22|19\n22|72\n22|24\n22|89\n22|52\n22|25\n22|75\n22|36\n74|39\n74|83\n74|93\n74|48\n74|51\n74|67\n74|42\n74|34\n74|17\n74|27\n74|58\n74|72\n74|18\n74|91\n74|22\n74|62\n74|69\n74|86\n74|87\n74|79\n74|19\n74|66\n74|26\n74|92\n86|62\n86|99\n86|19\n86|96\n86|23\n86|11\n86|65\n86|58\n86|15\n86|61\n86|66\n86|79\n86|17\n86|95\n86|25\n86|75\n86|22\n86|46\n86|72\n86|41\n86|12\n86|64\n86|63\n86|39\n52|17\n52|88\n52|93\n52|62\n52|92\n52|48\n52|91\n52|69\n52|28\n52|83\n52|74\n52|27\n52|86\n52|26\n52|79\n52|51\n52|34\n52|66\n52|18\n52|87\n52|42\n52|58\n52|53\n52|67\n53|93\n53|26\n53|87\n53|48\n53|86\n53|67\n53|74\n53|42\n53|17\n53|92\n53|62\n53|58\n53|66\n53|39\n53|51\n53|27\n53|79\n53|28\n53|91\n53|83\n53|69\n53|34\n53|22\n53|18\n82|52\n82|85\n82|24\n82|88\n82|74\n82|17\n82|48\n82|67\n82|53\n82|26\n82|83\n82|92\n82|28\n82|51\n82|69\n82|18\n82|27\n82|87\n82|34\n82|86\n82|42\n82|89\n82|93\n82|91\n65|74\n65|28\n65|99\n65|88\n65|64\n65|52\n65|61\n65|46\n65|27\n65|24\n65|53\n65|63\n65|95\n65|85\n65|75\n65|36\n65|41\n65|87\n65|89\n65|11\n65|12\n65|23\n65|25\n65|82\n34|66\n34|19\n34|39\n34|83\n34|22\n34|72\n34|64\n34|93\n34|79\n34|12\n34|15\n34|86\n34|75\n34|41\n34|96\n34|62\n34|69\n34|65\n34|46\n34|63\n34|17\n34|58\n34|42\n34|25\n95|36\n95|18\n95|52\n95|67\n95|24\n95|89\n95|92\n95|82\n95|88\n95|48\n95|61\n95|26\n95|53\n95|74\n95|28\n95|51\n95|91\n95|87\n95|23\n95|85\n95|34\n95|83\n95|27\n95|99\n88|53\n88|26\n88|91\n88|69\n88|28\n88|17\n88|86\n88|62\n88|83\n88|58\n88|48\n88|87\n88|22\n88|27\n88|42\n88|51\n88|92\n88|66\n88|18\n88|34\n88|93\n88|74\n88|67\n88|79\n92|17\n92|91\n92|83\n92|34\n92|69\n92|51\n92|42\n92|93\n92|15\n92|86\n92|62\n92|67\n92|63\n92|39\n92|19\n92|26\n92|72\n92|66\n92|48\n92|79\n92|65\n92|58\n92|22\n92|96\n18|42\n18|15\n18|22\n18|67\n18|62\n18|58\n18|86\n18|39\n18|17\n18|66\n18|26\n18|34\n18|83\n18|72\n18|96\n18|92\n18|19\n18|79\n18|69\n18|51\n18|93\n18|65\n18|91\n18|48\n79|85\n79|15\n79|65\n79|89\n79|39\n79|75\n79|11\n79|61\n79|63\n79|12\n79|41\n79|72\n79|82\n79|19\n79|36\n79|99\n79|24\n79|64\n79|25\n79|46\n79|95\n79|22\n79|96\n79|23\n96|74\n96|95\n96|85\n96|65\n96|52\n96|25\n96|23\n96|36\n96|89\n96|53\n96|24\n96|11\n96|41\n96|64\n96|88\n96|63\n96|99\n96|61\n96|46\n96|75\n96|28\n96|12\n96|82\n69|12\n69|62\n69|65\n69|86\n69|79\n69|11\n69|58\n69|17\n69|63\n69|15\n69|93\n69|39\n69|75\n69|42\n69|46\n69|41\n69|96\n69|64\n69|72\n69|19\n69|25\n69|22\n41|18\n41|64\n41|52\n41|74\n41|23\n41|95\n41|53\n41|89\n41|85\n41|25\n41|36\n41|82\n41|99\n41|46\n41|87\n41|92\n41|27\n41|75\n41|11\n41|88\n41|24\n66|23\n66|41\n66|22\n66|25\n66|79\n66|11\n66|82\n66|15\n66|64\n66|61\n66|36\n66|12\n66|19\n66|65\n66|85\n66|39\n66|46\n66|63\n66|72\n66|89\n25|88\n25|26\n25|92\n25|28\n25|46\n25|95\n25|11\n25|23\n25|36\n25|87\n25|82\n25|27\n25|53\n25|18\n25|52\n25|24\n25|85\n25|64\n25|99\n11|48\n11|89\n11|18\n11|87\n11|28\n11|23\n11|34\n11|85\n11|92\n11|36\n11|52\n11|24\n11|91\n11|27\n11|53\n11|99\n11|88\n11|67\n17|95\n17|99\n17|36\n17|79\n17|61\n17|15\n17|11\n17|19\n17|65\n17|96\n17|22\n17|12\n17|25\n17|23\n17|72\n17|75\n17|66\n63|85\n63|99\n63|74\n63|36\n63|82\n63|18\n63|61\n63|41\n63|95\n63|89\n63|64\n63|28\n63|23\n63|87\n63|75\n63|88\n72|52\n72|88\n72|46\n72|64\n72|41\n72|25\n72|12\n72|99\n72|96\n72|63\n72|15\n72|19\n72|75\n72|65\n72|89\n61|88\n61|82\n61|67\n61|89\n61|26\n61|92\n61|28\n61|53\n61|48\n61|85\n61|18\n61|36\n61|24\n61|34\n19|12\n19|11\n19|82\n19|63\n19|61\n19|88\n19|96\n19|23\n19|95\n19|15\n19|24\n19|53\n19|99\n39|63\n39|65\n39|24\n39|89\n39|41\n39|72\n39|19\n39|46\n39|88\n39|11\n39|52\n39|75\n58|66\n58|12\n58|79\n58|61\n58|41\n58|46\n58|19\n58|11\n58|96\n58|15\n58|99\n75|95\n75|24\n75|36\n75|27\n75|52\n75|67\n75|23\n75|85\n75|26\n75|92\n89|28\n89|18\n89|34\n89|53\n89|51\n89|92\n89|48\n89|42\n89|83\n36|34\n36|88\n36|69\n36|89\n36|83\n36|48\n36|27\n36|51\n27|62\n27|86\n27|42\n27|58\n27|51\n27|79\n27|92\n91|79\n91|65\n91|64\n91|19\n91|25\n91|86\n15|89\n15|25\n15|99\n15|64\n15|24\n93|42\n93|86\n93|19\n93|96\n28|83\n28|66\n28|27\n67|19\n67|15\n23|91\n\n27,51,67,91,42,86,58,66,39,72,96\n88,64,61,72,82,46,36,63,41,95,75\n17,62,58,66,79,22,39,72,19,96,65,63,12,41,25,46,64,75,11,95,99,23,61\n12,41,39,93,95,66,86,62,42,11,58\n18,92,26,48,67,83,69,42,62,58,66,79,39,19,15\n64,46,61,66,63,99,23,11,75,17,41\n46,75,11,95,99,61,36,82,85,24,52,53,74,87,27,18,92,26,48\n18,92,61,74,27,48,99,67,89,36,52,26,11,91,95\n75,22,85,36,15,89,72,39,79,99,46,61,23,11,19,64,95\n66,58,72,93,79,17,34,65,42,64,39\n83,87,51,42,69,93,91,26,24,89,88,17,86,18,53,92,67\n83,93,42,86,66,96,15,63,12,41,25,64,75\n67,95,53,87,75,92,18,36,99\n25,64,11,23,24,99,15,96,88,61,46,95,63\n51,91,83,69,42,17,62,58,66,79,22,39,72\n26,69,86,66,72,15,63\n34,91,92,22,17,74,58,79,66,53,83\n87,86,51,26,28,17,18,92,24,67,27,42,91,85,34,53,69\n51,67,91,34,83,69,93,42,86,17,62,58,66,79,22,72,19,96,15,65,63,12,41\n48,69,83,27,42,86,34,62,93,58,53,18,88,67,52,87,24,91,74\n96,15,65,63,12,41,25,46,64,75,11,95,23,61,36,82,89,52,88,53,28\n72,95,11,41,89,19,82,12,63,79,22,25,36,65,61,96,66,75,39,64,15,23,99\n41,39,22,25,69,11,86,93,66,42,19,46,64,72,15,79,96,65,58,12,75\n12,41,25,46,64,11,23,61,36,82,89,85,24,52,53,28,74,87,27\n42,83,79,28,66,74,48,53,26,93,62,67,51,91,18,88,87\n34,19,96,15,66,17,69,22,79,26,72,86,67,91,48,18,39,93,51,92,42\n91,34,83,69,93,86,17,62,58,79,22,39,72,19,96,15,65,63,12,25,46\n99,23,61,36,82,24,88,53,28,74,87,27,92,26,48,34,83\n96,15,65,63,12,41,25,46,64,75,11,95,99,61,36,82,85,24,52,88,28\n66,27,48,18,96\n11,95,99,82,52,53,27,92,48\n17,66,39,12,41,93,51\n86,62,58,66,22,72,19,96,15,65,63,12,41,25,46,64,75,11,95,99,23\n26,85,27,52,92,82,34,51,87,83,67,23,89,36,74,24,28,69,53,91,18\n46,64,75,11,95,99,23,61,36,82,89,85,52,88,53,74,87,18,92,26,48\n83,85,92,87,88,74,28,48,18,52,82,93,24\n17,22,19,63,99\n79,11,39,86,19,65,46,62,93,42,64,96,69,25,72,66,15,12,41,58,22\n15,41,72,23,64,99,62,36,12,58,25,95,96\n74,92,51,28,91,34,69,42,67,48,66,87,26,27,22,79,93,39,18,17,83\n66,93,91,72,67,87,83,22,86,18,42,39,51,34,62,27,69,17,74,58,92\n62,34,58,66,72,42,51,17,86\n75,61,12,87,95,99,82,11,52,64,74,36,28\n87,27,18,48,51,83,93,86,62,58,66,79,39,72,19\n87,51,42,88,74,26,52,53,17,24,27,83,86,34,62,92,18,48,93,58,28\n72,96,41,64,95,36,88\n61,88,82,67,91,28,36,89,52,83,23,87,34,26,18,51,69,48,24\n88,53,28,74,87,27,18,92,26,48,51,34,83,69,93,42,86,17,58,66,79\n36,27,18,82,92,83,99\n89,61,34,88,82,93,91\n75,24,72,61,96,63,82,39,41,52,15,65,95\n74,53,24,18,26,36,88\n91,34,83,93,42,86,17,62,58,66,22,39,72,19,96,15,65,63,12,25,46\n72,96,12,41,25,75,23,89,88\n11,25,27,75,24,74,82,85,88,53,36,87,95,28,63,64,89\n89,82,52,74,27,63,61,95,53\n89,52,51,95,99,53,85,11,18,23,88,87,27,28,64\n61,36,89,87,83,69,93\n62,67,12,72,25,19,42,39,83,66,65,63,34,41,86,58,79,22,91\n69,42,63,22,79,39,15,96,12,65,67,86,91,93,58,48,72,51,83\n82,89,24,52,53,74,87,27,18,92,26,48,51,67,91,34,69,42,86\n87,27,18,92,26,48,51,67,91,83,93,86,17,62,66,79,22\n72,19,86,25,96,23,12,95,39,11,22,41,99,46,63\n46,25,86,66,22,96,63,62,42,93,69,39,15,12,79,64,34\n92,87,18,53,83,58,22,93,91,74,51\n17,62,58,66,79,22,39,72,96,15,65,63,12,41,25,46,64,75,11,95,99,23,61\n58,66,79,72,12,75,95,61,82\n19,15,41,25,46,64,75,36,85,52,53\n26,79,66,17,91,18,93,62,34,92,58,51,67,83,53,74,28,88,42,27,87\n26,18,28,69,27,48,89,51,42,36,24,91,83\n72,41,22,61,79,23,63,65,36,62,11,46,99,15,25,95,19,75,12,58,64\n34,83,69,93,42,17,58,79,22,39,72,19,96,15,63,41,25,46,64\n74,87,18,26,48,67,91,34,83,69,93,42,17,62,22,39,72\n83,79,66,15,91,63,96,25,58,12,72,65,62,34,69,19,39,42,22,86,41,67,93\n96,15,65,63,41,25,64,61,82,89,24,52,28\n11,23,61,36,82,24,88,53,28,27,18,92,26,48,51,67,91\n93,51,69,34,41,96,22,17,19,58,65,15,79,62,39,63,91,83,42\n65,63,12,41,25,46,64,75,11,95,99,23,61,36,82,89,85,24,52,88,53,74,87\n46,95,11,41,19,23,89,65,96,99,66,36,25,12,72,75,82,64,15,79,61,39,22\n23,75,74,82,53,11,88,24,27,18,85,95,87,25,36,46,26,92,64,99,89,61,28\n52,11,27,12,61,74,24,63,75,64,46,36,89,95,99,87,41,82,85,88,28,23,25\n82,24,88,53,28,74,87,27,18,92,26,48,51,67,91,34,83,69,93,42,86\n88,63,61,52,75,23,12,89,72,36,95\n89,95,63,39,36,41,46,19,72,24,64,25,85,75,61,22,99\n99,82,89,24,52,88,53,28,87,27,92,26,48,51,91,34,83\n51,69,72,91,79,86,93,96,48,22,27,42,62\n46,22,65,83,86,39,62,69,15,64,75,63,42,17,96,66,58,41,25,72,19\n83,69,86,17,62,58,66,79,22,39,72,19,15,65,63,12,41,25,46,64,75\n74,67,28,42,26,91,18\n15,65,12,25,11,95,99,61,36,82,85,24,88,28,74\n69,93,42,86,17,62,58,66,79,22,72,19,96,15,65,63,12,41,25,46,64,75,11\n95,99,23,82,89,88,28,74,27,18,92\n95,23,61,82,89,85,24,52,53,74,27,18,92\n41,62,64,42,69,72,11\n19,65,11,95,89,46,25,36,66,22,23,12,72,63,41,79,64,82,15,39,75,99,96\n58,22,72,36,65,39,25,23,64,96,82,99,11,41,79,15,66,19,12\n23,61,82,89,24,52,28,18,51,67,91\n58,66,22,39,72,19,96,65,12,41,25,46,75,95,23,61,36\n36,66,22,15,46,41,64\n93,69,92,36,24,83,82,87,53,52,61,85,91,74,26,89,34,18,88\n82,89,85,52,88,28,74,27,92,26,48,51,67,91,34,83,69,42,86\n95,39,22,58,72,23,99,12,63,25,75,96,62\n11,95,99,36,82,89,85,52,88,53,28,74,87,27,18,26,48,67,91\n72,96,15,65,12,46,64,75,11,95,36\n95,99,23,61,36,82,89,85,24,88,53,28,74,87,27,92,26,91,34\n34,18,27,92,67,95,23,61,48,51,53,26,85,91,88,99,74,89,28\n42,24,85,69,26,28,74,89,88,36,83\n58,66,79,22,39,96,15,65,63,64,11,99,23,36,82\n28,48,67,83,42,22,39\n93,82,69,74,51,24,34,85,89,42,36,52,27,53,28,92,67,91,83,87,88,26,48\n18,83,28,17,66,69,93,26,52\n85,89,53,26,36,46,88,24,99,52,27,25,18,92,75,74,11\n17,62,58,66,22,72,19,96,15,65,63,12,41,25,46,64,75,11,99,23,61\n58,66,79,39,19,96,65,63,75,95,99\n61,36,82,89,85,24,52,88,28,74,87,27,18,92,26,48,51,91,34,83,69\n63,41,25,46,64,95,23,61,89,85,24,52,53,28,74,87,27\n79,22,39,72,19,15,65,63,12,41,25,46,75,11,95,99,23,36,82,89,85\n65,11,25,53,82,88,74,12,15,63,41,64,89,23,24,99,46,75,95,52,36\n52,27,61,87,24\n62,39,15,65,63,41,11,95,99\n67,19,34,15,12,63,72\n85,23,79,95,11,39,19,46,72\n83,93,51,86,69,91,48,19,22,96,34,58,79,17,26,92,65\n83,74,67,88,18,69,34,27,51,92,42,66,28,53,91,62,26,87,48,17,79\n42,17,66,79,72,19,15,12,25,46,64,95,99\n28,18,64,87,25,99,74,89,82,11,36,24,75,61,12\n62,92,48,79,17,53,27,18,83,28,86,69,67,88,74\n83,91,48,93,36,24,92,74,89,88,69,42,51,85,26,18,52,34,53,87,82\n46,64,99,82,28,26,48\n12,95,23,99,75,64,41,15,74,24,11\n22,72,19,96,15,65,63,25,46,75,99,23,36,82,89,85,24\n41,25,64,11,95,23,85,24,87\n87,27,48,51,83,69,93,17,58,72,19\n25,79,64,96,99,66,15,39,11,12,63,61,75,89,41,82,46,95,72,19,65\n85,48,42,52,69,26,83,24,93,74,36,34,67\n27,87,92,24,99,46,11,64,53,75,95,88,74,26,89,28,52,85,25\n89,24,52,74,87,27,92,48,67,34,69,86,17\n17,89,83,24,92\n17,58,39,96,15,65,63,12,41,64,75,95,99,23,61\n82,12,46,61,25,15,53,65,75,99,36,24,88,52,28,89,41,11,23,85,64,74,95\n86,19,69,18,93\n87,27,92,26,48,51,67,91,34,83,69,93,42,86,17,62,58,66,79,22,39,72,19\n95,87,27,26,91,36,24,23,74,82,89,53,85,28,52,51,88,48,92,11,61,99,18\n74,87,27,92,26,48,91,34,83,93,42,17,62,58,66,79,22,39,72\n48,88,85,52,46,92,24,99,74,36,89,61,27,23,64,26,87\n12,95,18,41,85,23,61\n39,96,41,46,11,36,52\n93,42,86,17,62,58,22,39,96,15,65,41,25,46,75,11,95\n82,85,53,28,26,67,86\n46,99,11,39,64,58,42,65,19,22,15,75,95,17,25,79,86,12,72\n15,65,64,95,36,82,85,24,88,53,28\n99,23,24,64,95,87,65\n63,61,95,24,53,64,88,27,52,85,74\n96,64,11,95,99,61,36,82,89,85,28\n89,46,25,88,18,11,92,28,82,87,52,95,53,99,26,75,74,36,27,64,24\n99,75,11,85,25,27,92,95,52,74,87,61,82,18,24,41,36\n22,96,15,63,25,11,61,89,24\n88,53,58,79,83,93,48,87,92\n41,58,93,12,15,22,67,96,83,79,25,66,19\n66,93,41,69,72,62,46,63,15,17,19,58,65,96,83\n15,22,72,24,64,96,41,75,23\n34,26,91,52,67,48,92,51,27\n85,87,65,24,28,88,36,89,52,11,99,23,61,12,63,41,82\n53,63,99,61,12,95,74,36,41,88,23,28,15,85,64\n42,93,39,91,69,19,79,58,41,72,63,86,66,12,17,62,22,46,83,65,25,15,34\n82,88,83,99,61,28,85,26,87,18,34,51,48\n27,26,48,51,67,91,34,83,42,62,58,79,22,39,72,19,96\n92,26,48,67,91,34,69,93,42,86,58,66,79,22,39,72,19,15,65\n27,92,88,34,69,51,18,85,93,24,62,52,26\n36,85,15,88,96,11,64,75,53,28,61\n89,87,27,52,28,85,18,61,24,67,99,91,74,51,11,92,95\n34,83,69,93,42,17,62,58,66,79,22,72,19,96,15,65,63,12,41,46,64\n65,25,79,93,46,72,83,86,58,63,66,91,34,15,41\n17,52,88,18,85,89,91\n42,91,28,58,48,17,26,67,24,74,69,62,34,83,52\n82,85,24,52,28,74,87,27,18,92,91,34,69,42,86\n58,12,41,66,83,42,19,17,62,79,46,25,22,15,39,93,65,96,69,63,34,91,86\n63,15,83,65,46,25,69,19,42,75,39,79,41,12,62,72,58\n69,17,62,66,96,25,75\n26,48,67,91,34,83,69,42,86,17,58,79,22,39,72,19,63\n72,19,65,46,64,75,11,82,24\n64,63,99,46,17,19,22,65,15,61,58,23,72\n83,79,65,15,42,39,91,69,72,34,86,17,62,63,66,58,51,22,96,93,12,67,41\n34,51,69,66,92,42,26,18,52,67,53,27,17,83,28,93,87,88,91,86,74\n74,87,27,18,92,26,48,51,34,83,93,86,17,62,58,66,79,39,72\n91,42,63,96,79,62,22,51,26,65,72\n86,93,26,66,48,74,18,17,58,27,91,51,79,39,34,28,92\n24,75,46,27,82,89,36,28,64,87,25,18,95,61,74,53,92,88,99,52,23,41,11\n85,23,87,36,61,89,74,99,27,64,95,53,11,26,18,25,88,46,75,52,82\n74,64,82,87,27\n62,66,46,58,75,79,65,64,72,19,39,25,41,12,96,36,11,99,23,22,61\n48,51,67,91,34,93,42,17,58,66,39,19,96,15,65,63,12\n28,93,26,58,87,91,69,86,22,53,66\n18,92,26,48,51,67,91,34,69,93,42,86,17,62,58,66,79,39,96\n96,15,65,63,12,25,46,11,95,99,61,82,89,85,24,52,88\n42,91,93,65,63,17,72,51,19,79,83,69,41\n24,61,67,52,11,36,99,85,53,82,51";
    // public static readonly string trialData = "96|15\n69|95\n69|66\n41|61\n41|26\n41|28\n66|75\n66|96\n66|99\n66|95\n25|74\n25|89\n25|48\n25|61\n25|75\n11|74\n11|26\n11|51\n11|82\n11|95\n11|61\n17|58\n17|63\n17|41\n17|39\n17|62\n17|64\n17|46\n63|25\n63|27\n63|46\n63|24\n63|12\n63|53\n63|11\n63|52\n72|24\n72|11\n72|23\n72|85\n72|61\n72|82\n72|53\n72|36\n72|95\n61|74\n61|83\n61|91\n61|93\n61|87\n61|52\n61|69\n61|51\n61|42\n61|27\n19|36\n19|89\n19|75\n19|85\n19|25\n19|28\n19|65\n19|52\n19|41\n19|46\n19|64\n39|23\n39|96\n39|64\n39|12\n39|82\n39|15\n39|95\n39|99\n39|85\n39|36\n39|25\n39|61\n58|25\n58|63\n58|65\n58|23\n58|95\n58|39\n58|36\n58|64\n58|22\n58|82\n58|72\n58|75\n58|89\n75|74\n75|87\n75|61\n75|89\n75|99\n75|18\n75|53\n75|11\n75|88\n75|48\n75|28\n75|82\n75|91\n75|51\n89|69\n89|26\n89|24\n89|87\n89|74\n89|52\n89|67\n89|17\n89|91\n89|86\n89|27\n89|85\n89|93\n89|88\n89|62\n36|53\n36|67\n36|92\n36|93\n36|82\n36|85\n36|28\n36|18\n36|91\n36|74\n36|52\n36|24\n36|42\n36|87\n36|26\n36|86\n27|17\n27|91\n27|69\n27|48\n27|66\n27|34\n27|83\n27|19\n27|26\n27|22\n27|96\n27|93\n27|18\n27|72\n27|67\n27|15\n27|39\n91|72\n91|46\n91|41\n91|17\n91|66\n91|63\n91|39\n91|93\n91|15\n91|96\n91|34\n91|12\n91|83\n91|69\n91|42\n91|58\n91|22\n91|62\n15|63\n15|65\n15|85\n15|82\n15|36\n15|75\n15|88\n15|61\n15|95\n15|52\n15|28\n15|74\n15|11\n15|12\n15|46\n15|53\n15|41\n15|23\n15|87\n93|46\n93|41\n93|25\n93|75\n93|72\n93|66\n93|99\n93|12\n93|58\n93|22\n93|17\n93|15\n93|39\n93|65\n93|63\n93|62\n93|79\n93|11\n93|64\n93|95\n28|51\n28|72\n28|22\n28|91\n28|17\n28|26\n28|79\n28|18\n28|62\n28|34\n28|67\n28|69\n28|93\n28|58\n28|39\n28|48\n28|74\n28|87\n28|86\n28|42\n28|92\n67|91\n67|41\n67|17\n67|12\n67|79\n67|58\n67|96\n67|72\n67|63\n67|65\n67|42\n67|46\n67|39\n67|86\n67|25\n67|93\n67|22\n67|62\n67|69\n67|66\n67|34\n67|83\n23|34\n23|93\n23|82\n23|24\n23|87\n23|69\n23|83\n23|18\n23|67\n23|85\n23|26\n23|52\n23|88\n23|51\n23|89\n23|61\n23|48\n23|53\n23|36\n23|28\n23|27\n23|92\n23|74\n26|34\n26|66\n26|93\n26|96\n26|63\n26|62\n26|65\n26|22\n26|67\n26|69\n26|12\n26|17\n26|15\n26|48\n26|91\n26|39\n26|86\n26|19\n26|51\n26|83\n26|72\n26|42\n26|79\n26|58\n12|23\n12|82\n12|11\n12|27\n12|46\n12|25\n12|92\n12|61\n12|18\n12|85\n12|75\n12|53\n12|52\n12|89\n12|41\n12|88\n12|87\n12|74\n12|99\n12|95\n12|36\n12|64\n12|24\n12|28\n24|52\n24|18\n24|53\n24|42\n24|92\n24|48\n24|66\n24|58\n24|88\n24|62\n24|93\n24|69\n24|27\n24|91\n24|67\n24|34\n24|51\n24|74\n24|17\n24|83\n24|26\n24|87\n24|28\n24|86\n62|79\n62|58\n62|96\n62|41\n62|22\n62|11\n62|15\n62|65\n62|36\n62|75\n62|64\n62|82\n62|99\n62|95\n62|66\n62|46\n62|72\n62|23\n62|12\n62|61\n62|19\n62|39\n62|63\n62|25\n48|65\n48|39\n48|93\n48|15\n48|62\n48|67\n48|51\n48|19\n48|79\n48|42\n48|66\n48|96\n48|17\n48|72\n48|91\n48|34\n48|41\n48|86\n48|22\n48|58\n48|63\n48|69\n48|12\n48|83\n85|74\n85|42\n85|17\n85|26\n85|91\n85|53\n85|67\n85|87\n85|88\n85|62\n85|51\n85|58\n85|83\n85|69\n85|24\n85|52\n85|34\n85|27\n85|28\n85|92\n85|48\n85|86\n85|18\n85|93\n83|15\n83|72\n83|66\n83|86\n83|62\n83|65\n83|17\n83|79\n83|58\n83|64\n83|22\n83|12\n83|11\n83|39\n83|25\n83|63\n83|41\n83|96\n83|42\n83|69\n83|75\n83|46\n83|19\n83|93\n64|75\n64|26\n64|48\n64|27\n64|51\n64|87\n64|74\n64|92\n64|95\n64|85\n64|18\n64|52\n64|82\n64|11\n64|61\n64|28\n64|53\n64|23\n64|36\n64|88\n64|24\n64|89\n64|67\n64|99\n99|83\n99|82\n99|18\n99|91\n99|53\n99|89\n99|48\n99|27\n99|69\n99|24\n99|88\n99|74\n99|52\n99|28\n99|36\n99|34\n99|92\n99|23\n99|85\n99|87\n99|61\n99|67\n99|26\n99|51\n42|17\n42|65\n42|72\n42|63\n42|15\n42|12\n42|99\n42|66\n42|75\n42|62\n42|22\n42|95\n42|19\n42|58\n42|46\n42|11\n42|96\n42|39\n42|23\n42|25\n42|86\n42|64\n42|79\n42|41\n51|69\n51|58\n51|79\n51|25\n51|63\n51|17\n51|65\n51|67\n51|41\n51|39\n51|19\n51|62\n51|93\n51|12\n51|83\n51|86\n51|42\n51|91\n51|34\n51|66\n51|15\n51|72\n51|22\n51|96\n87|58\n87|51\n87|96\n87|42\n87|93\n87|83\n87|19\n87|17\n87|72\n87|48\n87|22\n87|79\n87|39\n87|67\n87|62\n87|86\n87|92\n87|27\n87|34\n87|69\n87|66\n87|91\n87|18\n87|26\n46|87\n46|64\n46|28\n46|74\n46|24\n46|26\n46|27\n46|85\n46|61\n46|48\n46|18\n46|95\n46|89\n46|88\n46|36\n46|92\n46|23\n46|75\n46|11\n46|82\n46|53\n46|52\n46|51\n46|99\n22|95\n22|41\n22|99\n22|63\n22|61\n22|15\n22|39\n22|82\n22|85\n22|96\n22|64\n22|23\n22|11\n22|65\n22|46\n22|12\n22|19\n22|72\n22|24\n22|89\n22|52\n22|25\n22|75\n22|36\n74|39\n74|83\n74|93\n74|48\n74|51\n74|67\n74|42\n74|34\n74|17\n74|27\n74|58\n74|72\n74|18\n74|91\n74|22\n74|62\n74|69\n74|86\n74|87\n74|79\n74|19\n74|66\n74|26\n74|92\n86|62\n86|99\n86|19\n86|96\n86|23\n86|11\n86|65\n86|58\n86|15\n86|61\n86|66\n86|79\n86|17\n86|95\n86|25\n86|75\n86|22\n86|46\n86|72\n86|41\n86|12\n86|64\n86|63\n86|39\n52|17\n52|88\n52|93\n52|62\n52|92\n52|48\n52|91\n52|69\n52|28\n52|83\n52|74\n52|27\n52|86\n52|26\n52|79\n52|51\n52|34\n52|66\n52|18\n52|87\n52|42\n52|58\n52|53\n52|67\n53|93\n53|26\n53|87\n53|48\n53|86\n53|67\n53|74\n53|42\n53|17\n53|92\n53|62\n53|58\n53|66\n53|39\n53|51\n53|27\n53|79\n53|28\n53|91\n53|83\n53|69\n53|34\n53|22\n53|18\n82|52\n82|85\n82|24\n82|88\n82|74\n82|17\n82|48\n82|67\n82|53\n82|26\n82|83\n82|92\n82|28\n82|51\n82|69\n82|18\n82|27\n82|87\n82|34\n82|86\n82|42\n82|89\n82|93\n82|91\n65|74\n65|28\n65|99\n65|88\n65|64\n65|52\n65|61\n65|46\n65|27\n65|24\n65|53\n65|63\n65|95\n65|85\n65|75\n65|36\n65|41\n65|87\n65|89\n65|11\n65|12\n65|23\n65|25\n65|82\n34|66\n34|19\n34|39\n34|83\n34|22\n34|72\n34|64\n34|93\n34|79\n34|12\n34|15\n34|86\n34|75\n34|41\n34|96\n34|62\n34|69\n34|65\n34|46\n34|63\n34|17\n34|58\n34|42\n34|25\n95|36\n95|18\n95|52\n95|67\n95|24\n95|89\n95|92\n95|82\n95|88\n95|48\n95|61\n95|26\n95|53\n95|74\n95|28\n95|51\n95|91\n95|87\n95|23\n95|85\n95|34\n95|83\n95|27\n95|99\n88|53\n88|26\n88|91\n88|69\n88|28\n88|17\n88|86\n88|62\n88|83\n88|58\n88|48\n88|87\n88|22\n88|27\n88|42\n88|51\n88|92\n88|66\n88|18\n88|34\n88|93\n88|74\n88|67\n88|79\n92|17\n92|91\n92|83\n92|34\n92|69\n92|51\n92|42\n92|93\n92|15\n92|86\n92|62\n92|67\n92|63\n92|39\n92|19\n92|26\n92|72\n92|66\n92|48\n92|79\n92|65\n92|58\n92|22\n92|96\n18|42\n18|15\n18|22\n18|67\n18|62\n18|58\n18|86\n18|39\n18|17\n18|66\n18|26\n18|34\n18|83\n18|72\n18|96\n18|92\n18|19\n18|79\n18|69\n18|51\n18|93\n18|65\n18|91\n18|48\n79|85\n79|15\n79|65\n79|89\n79|39\n79|75\n79|11\n79|61\n79|63\n79|12\n79|41\n79|72\n79|82\n79|19\n79|36\n79|99\n79|24\n79|64\n79|25\n79|46\n79|95\n79|22\n79|96\n79|23\n96|74\n96|95\n96|85\n96|65\n96|52\n96|25\n96|23\n96|36\n96|89\n96|53\n96|24\n96|11\n96|41\n96|64\n96|88\n96|63\n96|99\n96|61\n96|46\n96|75\n96|28\n96|12\n96|82\n69|12\n69|62\n69|65\n69|86\n69|79\n69|11\n69|58\n69|17\n69|63\n69|15\n69|93\n69|39\n69|75\n69|42\n69|46\n69|41\n69|96\n69|64\n69|72\n69|19\n69|25\n69|22\n41|18\n41|64\n41|52\n41|74\n41|23\n41|95\n41|53\n41|89\n41|85\n41|25\n41|36\n41|82\n41|99\n41|46\n41|87\n41|92\n41|27\n41|75\n41|11\n41|88\n41|24\n66|23\n66|41\n66|22\n66|25\n66|79\n66|11\n66|82\n66|15\n66|64\n66|61\n66|36\n66|12\n66|19\n66|65\n66|85\n66|39\n66|46\n66|63\n66|72\n66|89\n25|88\n25|26\n25|92\n25|28\n25|46\n25|95\n25|11\n25|23\n25|36\n25|87\n25|82\n25|27\n25|53\n25|18\n25|52\n25|24\n25|85\n25|64\n25|99\n11|48\n11|89\n11|18\n11|87\n11|28\n11|23\n11|34\n11|85\n11|92\n11|36\n11|52\n11|24\n11|91\n11|27\n11|53\n11|99\n11|88\n11|67\n17|95\n17|99\n17|36\n17|79\n17|61\n17|15\n17|11\n17|19\n17|65\n17|96\n17|22\n17|12\n17|25\n17|23\n17|72\n17|75\n17|66\n63|85\n63|99\n63|74\n63|36\n63|82\n63|18\n63|61\n63|41\n63|95\n63|89\n63|64\n63|28\n63|23\n63|87\n63|75\n63|88\n72|52\n72|88\n72|46\n72|64\n72|41\n72|25\n72|12\n72|99\n72|96\n72|63\n72|15\n72|19\n72|75\n72|65\n72|89\n61|88\n61|82\n61|67\n61|89\n61|26\n61|92\n61|28\n61|53\n61|48\n61|85\n61|18\n61|36\n61|24\n61|34\n19|12\n19|11\n19|82\n19|63\n19|61\n19|88\n19|96\n19|23\n19|95\n19|15\n19|24\n19|53\n19|99\n39|63\n39|65\n39|24\n39|89\n39|41\n39|72\n39|19\n39|46\n39|88\n39|11\n39|52\n39|75\n58|66\n58|12\n58|79\n58|61\n58|41\n58|46\n58|19\n58|11\n58|96\n58|15\n58|99\n75|95\n75|24\n75|36\n75|27\n75|52\n75|67\n75|23\n75|85\n75|26\n75|92\n89|28\n89|18\n89|34\n89|53\n89|51\n89|92\n89|48\n89|42\n89|83\n36|34\n36|88\n36|69\n36|89\n36|83\n36|48\n36|27\n36|51\n27|62\n27|86\n27|42\n27|58\n27|51\n27|79\n27|92\n91|79\n91|65\n91|64\n91|19\n91|25\n91|86\n15|89\n15|25\n15|99\n15|64\n15|24\n93|42\n93|86\n93|19\n93|96\n28|83\n28|66\n28|27\n67|19\n67|15\n23|91\n\n36,27,18,82,92,83,99";
}
