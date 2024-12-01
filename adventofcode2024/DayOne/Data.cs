﻿namespace adventofcode2024.DayOne;

public static class Data
{
    public static class PartOne
    {
        public static readonly string testInput = "// 3   4\n// 4   3\n// 2   5\n// 1   3\n// 3   9\n// 3   3";
        public static readonly string trialInput = "77221   93653\n61169   27995\n49546   69782\n11688   41563\n15820   48282\n63235   37517\n28850   68189\n80735   25255\n42616   65322\n55068   99897\n30851   35509\n14907   49013\n64732   92011\n16709   68830\n67643   36207\n44080   23559\n96480   58330\n99450   40186\n21169   63410\n58096   21671\n53828   79572\n47026   44529\n90101   28656\n45773   73412\n71303   85991\n45304   78294\n96528   23559\n19794   17882\n74831   17211\n88912   11644\n98961   80435\n15788   96101\n16350   86995\n96806   19028\n99959   77868\n58887   90255\n42568   25255\n29278   88912\n94028   63269\n42810   21548\n97490   71747\n89051   24477\n73916   31808\n97751   88912\n73608   77868\n62426   13754\n29429   36177\n11070   10894\n78656   85185\n31308   60500\n96166   91114\n36906   85134\n99662   77868\n66402   41563\n37085   14475\n80907   53324\n61650   53324\n84223   63753\n83891   47827\n15973   77536\n68843   40593\n98854   31274\n42426   97404\n25255   67531\n44559   50141\n93909   50674\n28070   32858\n24880   24813\n29338   89795\n64883   77868\n66924   57646\n32984   66502\n32238   39062\n38816   23559\n58770   65322\n74953   91636\n70592   19028\n93111   11644\n31065   23537\n67370   19028\n18314   47412\n71075   74334\n21544   44529\n59137   50980\n20440   80749\n14393   38495\n72130   90255\n43828   68830\n23262   73660\n11923   50980\n47754   14164\n96043   34362\n27162   28090\n20838   50713\n75009   11121\n92099   31274\n22054   38248\n43518   80106\n68189   13153\n50520   12727\n51425   40674\n42998   31053\n52443   33051\n37256   54436\n16648   95555\n81123   17329\n46974   79835\n36328   77868\n76373   23559\n82592   70046\n70600   22417\n27116   89690\n28090   34969\n86348   23559\n53145   50980\n30203   83301\n23347   77681\n76433   26236\n28046   92869\n58920   50980\n25518   28090\n12791   44529\n61967   31808\n98022   53056\n24326   12263\n41095   13121\n24045   82448\n31274   16530\n78021   21589\n63029   19658\n75684   14475\n31258   36493\n40561   48589\n20457   54974\n14783   88465\n39433   23537\n34774   53324\n10455   14329\n26338   74416\n55227   37003\n36963   40380\n31910   68189\n94894   18220\n23166   44111\n48884   46787\n73036   89795\n83519   25205\n50205   93653\n85926   50141\n69194   23559\n25529   11642\n10182   31274\n13638   61987\n83588   19028\n75911   20768\n44692   24325\n43278   94888\n48148   24394\n86205   99327\n82605   58818\n52770   68189\n89068   84917\n66452   83679\n50217   85099\n64914   52073\n76460   78294\n43026   24410\n44179   50980\n47653   90255\n78061   50980\n14475   71478\n77868   37150\n99645   28090\n86267   70055\n58072   68830\n96428   66585\n77501   50141\n52344   93653\n49534   35509\n46925   12437\n40005   87987\n17329   86995\n17585   89795\n32296   59660\n81836   11644\n89435   65322\n55149   59423\n56971   50141\n26342   95142\n57894   56227\n49762   33007\n48949   65641\n40453   53505\n67613   23537\n27110   87987\n25231   63910\n92546   50713\n70074   27554\n39649   93653\n93231   30520\n60008   79179\n18449   47209\n68828   36207\n18908   72254\n55426   44661\n62522   87987\n60923   25255\n85721   68107\n35153   71814\n20053   24813\n24233   22904\n36237   92731\n92077   68189\n30105   50674\n37032   90255\n12745   54116\n41563   53324\n24700   29145\n60226   85335\n50713   64775\n29972   51790\n79176   19794\n40017   96101\n90724   41345\n51608   39176\n46178   50141\n26151   23489\n19569   44529\n34368   86052\n18948   50801\n62091   17329\n89749   38984\n68315   37514\n52396   19794\n14981   14475\n36038   69571\n50048   50980\n60796   41563\n69942   72877\n80976   25234\n56722   90255\n49489   28090\n60768   65557\n70753   85065\n15233   23522\n94697   87600\n40958   41532\n91709   40116\n83586   19028\n88140   24977\n56993   50980\n17980   53324\n12421   97982\n30183   40884\n50452   53324\n91314   90651\n69995   19028\n16588   28090\n22432   98658\n86088   77868\n46361   65322\n97178   75705\n37444   79320\n12275   96101\n47016   16942\n36822   87327\n62082   31274\n68265   64314\n87344   24603\n40642   23559\n87254   38755\n62372   50713\n89026   68830\n88519   96101\n53514   31808\n24686   41563\n23817   68705\n26704   89031\n37908   65322\n22665   35601\n75378   59200\n16797   86995\n55847   68189\n55932   72688\n41470   96101\n43557   17329\n45439   77868\n41230   76226\n25104   92869\n43736   93653\n85938   93653\n74153   54726\n73956   70350\n70419   37102\n81275   64160\n30656   32684\n46218   32617\n67969   31808\n61544   81806\n39376   56568\n14769   60336\n10199   97703\n61064   40091\n75531   30486\n17211   31808\n75184   74633\n24565   61765\n83922   44529\n11644   25255\n71836   14393\n53030   19028\n83437   33190\n33687   54998\n92054   82083\n48250   68533\n10977   34363\n51050   19028\n80898   68276\n26442   68830\n39875   65514\n24976   76417\n31946   23537\n95278   90255\n71678   26450\n49641   28580\n12962   13674\n13598   30362\n40620   21256\n49062   92869\n88449   79529\n80153   94081\n36918   70556\n77902   99228\n41848   99097\n26032   39378\n23830   50980\n49712   78294\n95464   65322\n76971   27393\n67074   22132\n17629   71246\n92019   92869\n20780   96521\n68372   16880\n49710   88060\n94680   52634\n28626   57101\n31808   60809\n25578   28090\n12020   25255\n46008   33046\n27712   36207\n17168   53033\n92923   87987\n94668   65843\n59490   48858\n69085   38485\n28242   14664\n18302   96101\n64047   71241\n62752   73532\n28873   59278\n22206   18029\n57298   85374\n26420   78294\n74055   30817\n74377   45566\n81846   17058\n35184   27305\n72054   89795\n78666   41563\n80545   96101\n69240   51322\n76319   36831\n23617   14475\n53848   93653\n65082   36888\n18802   93491\n63942   23559\n80208   22876\n17018   68830\n78018   51611\n35520   75130\n43479   88543\n18522   96101\n41260   15010\n58041   21675\n96272   68830\n73601   78294\n44788   52104\n67152   89795\n57671   61399\n33841   56764\n41963   53394\n41010   28090\n53937   65322\n75472   76675\n22253   92068\n24277   93653\n62012   14475\n27539   50141\n29180   41637\n27151   35922\n28752   23559\n31602   47673\n80298   50906\n94689   38297\n87987   48139\n51692   61967\n93653   86995\n99694   96638\n50948   11644\n87830   19794\n57579   93403\n60947   72082\n18514   53324\n99194   25255\n57630   93653\n49914   10526\n34613   94340\n32145   16105\n39569   62764\n14118   31274\n38901   19016\n47443   66925\n83812   31274\n61920   50141\n88684   50713\n32305   31808\n58695   50713\n20016   42720\n68955   31976\n96299   99509\n83258   96101\n49424   68830\n97130   14043\n34668   50936\n27567   35509\n57890   65959\n58399   78860\n88934   50980\n70656   66788\n91507   44529\n53671   87987\n75858   71137\n14726   13674\n25416   31274\n90521   50075\n37289   96101\n79415   19028\n21158   25355\n53210   16168\n35192   81526\n67240   23559\n42967   65310\n81598   93094\n12765   36207\n23853   41643\n78439   22984\n13052   50141\n56642   93653\n19028   82791\n89371   36244\n89795   50799\n41542   90489\n49486   72630\n26630   50763\n35019   68830\n62271   78294\n16433   77868\n42466   57338\n63666   39984\n56231   83564\n51132   96101\n33675   74200\n94670   70445\n51236   17822\n52493   64460\n45346   86995\n41620   31274\n80479   88912\n46200   90255\n13789   60686\n98564   76843\n44974   92717\n76047   80674\n60650   89430\n55723   45722\n89426   97853\n33961   98414\n32872   68189\n65322   12029\n29922   36159\n74923   34697\n37065   59688\n66622   23559\n68253   14475\n28664   53324\n62981   25761\n83161   50674\n22849   50980\n11119   76308\n22980   13794\n76171   19411\n96351   28221\n45573   90255\n19850   79146\n97828   90483\n23867   85271\n36353   50141\n46579   87987\n73434   23559\n57169   68189\n68768   41682\n59354   97617\n62181   64641\n34167   53324\n28374   24803\n55863   57352\n25058   33040\n76126   53005\n97283   51641\n25887   29253\n43067   50713\n51616   61868\n97533   16129\n50692   80951\n43173   41626\n93917   76055\n84713   53465\n24130   13599\n56773   50980\n15310   44529\n63375   50141\n75875   93653\n22284   33135\n46294   77836\n29713   14393\n95318   83346\n83264   61967\n39267   47771\n61101   86995\n47882   96101\n24345   70347\n50674   14475\n17296   12880\n52605   11644\n40817   78294\n36207   93653\n16045   96101\n91784   68830\n34583   69934\n71867   28090\n74898   22671\n54609   27206\n33070   26257\n18570   57394\n16766   87036\n62825   21503\n39793   17504\n12038   82452\n37265   12706\n69479   44529\n96101   44260\n49175   50713\n70708   55412\n50136   14475\n27300   96101\n75794   62368\n10277   87990\n30825   87987\n35563   24149\n12505   91890\n11323   14393\n89922   84455\n10927   65359\n50656   71304\n47973   11644\n17156   92869\n98964   96101\n50980   59345\n94733   23559\n22743   26134\n90255   54273\n80006   65322\n10157   92869\n70496   28090\n25569   41226\n79982   92869\n34897   76485\n83357   86388\n26352   79503\n67432   15174\n49155   72153\n36311   86995\n14394   65333\n70928   51667\n67367   23559\n48195   57003\n52001   26154\n63251   21651\n21894   89795\n50774   43252\n85637   36207\n79243   11644\n49512   57954\n22454   15919\n84214   20805\n67121   86995\n49247   78035\n79313   34840\n33168   19814\n48657   92888\n59824   74905\n30088   68830\n74246   90052\n78389   65322\n88418   28090\n93716   62226\n74962   29324\n47309   50980\n93517   14393\n23895   68175\n34548   25255\n32628   84730\n55988   31274\n82578   40953\n51728   16926\n19440   27805\n42922   45159\n52930   41563\n91562   31274\n23559   62680\n92150   26879\n78315   61783\n43601   91325\n87621   17838\n78580   65350\n94778   77868\n68519   83273\n35509   66389\n82288   52439\n65083   19794\n86995   13010\n66618   95850\n18656   70145\n98537   65322\n60842   52161\n68830   10132\n99689   24077\n33740   89795\n45595   53090\n78239   36207\n20185   36207\n87307   69366\n83009   77868\n34685   88642\n13674   28090\n82450   69909\n44812   75146\n54296   92869\n73558   94990\n21422   48229\n49473   10547\n66108   68189\n71169   74202\n78276   40690\n82977   78294\n61842   15634\n31582   95459\n39064   14475\n70204   18593\n71244   87987\n31642   50490\n98413   37109\n61175   50141\n37168   23559\n44093   11032\n18806   40848\n91249   73483\n95812   32572\n93644   68189\n30669   20850\n75404   92869\n53324   50141\n80675   50216\n14897   73401\n34074   29952\n16366   32630\n95656   28090\n73964   58896\n90705   66916\n92869   59662\n99522   78294\n35903   19794\n33033   42610\n55650   50980\n29289   11753\n32302   58345\n76036   57644\n74870   31274\n85035   77868\n79322   25255\n50332   31274\n78294   44529\n93000   53324\n36560   19028\n40041   53525\n70360   89795\n19074   98749\n32829   89603\n61436   71046\n89938   85369\n52708   28090\n83958   53324\n88155   67097\n32730   75527\n64221   23559\n60391   97432\n70047   20185\n12372   73527\n46501   29274\n66552   14746\n56373   51614\n95596   11782\n81196   72623\n32282   60515\n49504   14393\n57642   34348\n95402   87987\n81625   68830\n28527   37199\n71475   31808\n94280   23005\n55623   99355\n46783   29073\n36641   81559\n74788   14535\n87994   78773\n80189   77868\n33263   89795\n23537   23537\n25755   22264\n67413   72800\n74924   73774\n81215   78294\n78206   92869\n36161   50141\n54925   86995\n66305   49951\n42462   28090\n99051   88912\n44954   89795\n88856   28090\n63026   85778\n22651   24813\n39262   14475\n86176   69982\n65395   14393\n12926   78294\n81994   53324\n16933   30191\n46987   19794\n37215   28090\n15340   63748\n40271   86674\n23747   52856\n61156   11644\n65356   56048\n72336   51278\n21864   77868\n99351   13349\n24599   79046\n62281   23361\n81871   53324\n14029   42297\n50141   48720\n46677   43636\n10745   35965\n39344   80864\n38077   50038\n13983   89795\n66663   67877\n64175   19028\n62355   68830\n96823   79443\n46436   44754\n53388   68830\n45987   92723\n87646   11707\n75997   45545\n69968   93653\n30425   44529\n83211   88109\n28725   64932\n47043   89795\n34475   31274\n42302   94895\n66558   92753\n48964   50713\n19546   78294\n51026   89795\n89346   57408\n52993   54676\n29577   38385\n85932   60320\n18030   22556\n65993   19922\n74692   23559\n61588   89795\n50688   69541\n93760   44529\n75094   96101\n68976   86835\n46278   50980\n97836   44529\n17576   32708\n48519   46071\n72647   93653\n54724   34155\n45186   43448\n44529   41828\n90404   86357\n63175   44529\n88381   25963\n32140   23537\n43348   36423\n41733   88912\n84065   98953\n20389   96101\n38749   93788\n37929   35143\n63747   35340\n72249   93653\n98042   59381\n22741   95783\n88124   33425\n16493   44529\n36599   69408\n50436   41563\n67695   86149\n89091   20022\n60708   92607\n28750   68830\n80224   39113\n34580   96101\n79688   34798\n14870   68189\n47719   29252\n57652   33458\n65541   87987\n86435   19794\n95204   81239\n43800   50980\n94063   11644\n24096   36588\n36628   95478\n81443   17329\n61221   57166\n52782   78294\n16740   31274\n68369   45653\n28895   44529\n39222   65582\n97201   77602\n81119   11644\n41083   50141\n72917   25255\n46148   21269\n44495   18020\n99464   90525\n67254   58381\n52750   28135\n63899   55754\n14617   50713\n36962   50713\n41322   73436\n22504   38709\n72577   39875\n67799   68830\n68284   71156\n46011   61967\n50367   31808\n45832   87987\n88775   87987\n32562   26340\n43756   49887\n73444   16547\n67302   92449\n22133   85451\n17768   77868\n69281   39885\n87364   25255\n41209   27363\n37792   77868\n66667   73746\n22195   28090\n65037   37556\n28634   89795\n23901   50674\n40511   95801\n47779   45253\n76489   86807\n77873   66992\n87523   35509\n32876   50980\n62342   50980\n84222   41563\n88205   40382\n78856   20051\n97888   68189\n22233   17329\n35868   81437\n80155   93653\n82730   78294\n12733   19794\n55038   26258\n50682   23250\n42043   74279\n54719   71512\n54474   23991\n61776   25255\n55564   41563\n39404   31274\n94954   14475\n76258   89795\n87689   67995\n65619   59930\n41846   17435\n21990   22185\n60161   53026\n44955   57523\n84178   39875\n32693   87987\n19125   44529\n96731   93653\n98080   44529\n72947   95746\n67285   23344\n78101   77580\n43064   11644\n81350   23483\n46937   11644\n97686   79381\n66339   60744\n39269   50674\n61837   77868\n97647   86995\n44613   93568\n73127   68830\n64048   80370\n15530   87987\n63926   51860\n95853   91981\n26155   28090\n82222   19794\n10035   87445\n16445   93653\n67972   15558\n51780   68830\n52358   31274\n83942   60096\n64899   11955\n56009   96101\n42288   36590\n53349   65322\n76255   50713\n53044   26351\n37184   31274\n24813   19028\n62309   52490\n93607   19028\n27423   45568\n26128   78294\n72691   50141\n42162   60052\n78247   10613\n80209   31808\n38310   93653\n59228   47607\n24897   23559\n55176   37760\n33062   53324\n26521   39170\n93209   68189\n89881   23559\n11418   50980\n16884   78294\n31995   50980\n17858   98671\n49107   96101\n50512   54526\n56890   65322\n76173   65309\n51569   52845\n73919   23537\n62591   16739\n53735   79935\n14454   69804\n19976   46609\n";
    }

    public static class PartTwo
    {
        public static readonly string testInput = "3   4\n4   3\n2   5\n1   3\n3   9\n3   3";
        public static readonly string trialInput = "77221   93653\n61169   27995\n49546   69782\n11688   41563\n15820   48282\n63235   37517\n28850   68189\n80735   25255\n42616   65322\n55068   99897\n30851   35509\n14907   49013\n64732   92011\n16709   68830\n67643   36207\n44080   23559\n96480   58330\n99450   40186\n21169   63410\n58096   21671\n53828   79572\n47026   44529\n90101   28656\n45773   73412\n71303   85991\n45304   78294\n96528   23559\n19794   17882\n74831   17211\n88912   11644\n98961   80435\n15788   96101\n16350   86995\n96806   19028\n99959   77868\n58887   90255\n42568   25255\n29278   88912\n94028   63269\n42810   21548\n97490   71747\n89051   24477\n73916   31808\n97751   88912\n73608   77868\n62426   13754\n29429   36177\n11070   10894\n78656   85185\n31308   60500\n96166   91114\n36906   85134\n99662   77868\n66402   41563\n37085   14475\n80907   53324\n61650   53324\n84223   63753\n83891   47827\n15973   77536\n68843   40593\n98854   31274\n42426   97404\n25255   67531\n44559   50141\n93909   50674\n28070   32858\n24880   24813\n29338   89795\n64883   77868\n66924   57646\n32984   66502\n32238   39062\n38816   23559\n58770   65322\n74953   91636\n70592   19028\n93111   11644\n31065   23537\n67370   19028\n18314   47412\n71075   74334\n21544   44529\n59137   50980\n20440   80749\n14393   38495\n72130   90255\n43828   68830\n23262   73660\n11923   50980\n47754   14164\n96043   34362\n27162   28090\n20838   50713\n75009   11121\n92099   31274\n22054   38248\n43518   80106\n68189   13153\n50520   12727\n51425   40674\n42998   31053\n52443   33051\n37256   54436\n16648   95555\n81123   17329\n46974   79835\n36328   77868\n76373   23559\n82592   70046\n70600   22417\n27116   89690\n28090   34969\n86348   23559\n53145   50980\n30203   83301\n23347   77681\n76433   26236\n28046   92869\n58920   50980\n25518   28090\n12791   44529\n61967   31808\n98022   53056\n24326   12263\n41095   13121\n24045   82448\n31274   16530\n78021   21589\n63029   19658\n75684   14475\n31258   36493\n40561   48589\n20457   54974\n14783   88465\n39433   23537\n34774   53324\n10455   14329\n26338   74416\n55227   37003\n36963   40380\n31910   68189\n94894   18220\n23166   44111\n48884   46787\n73036   89795\n83519   25205\n50205   93653\n85926   50141\n69194   23559\n25529   11642\n10182   31274\n13638   61987\n83588   19028\n75911   20768\n44692   24325\n43278   94888\n48148   24394\n86205   99327\n82605   58818\n52770   68189\n89068   84917\n66452   83679\n50217   85099\n64914   52073\n76460   78294\n43026   24410\n44179   50980\n47653   90255\n78061   50980\n14475   71478\n77868   37150\n99645   28090\n86267   70055\n58072   68830\n96428   66585\n77501   50141\n52344   93653\n49534   35509\n46925   12437\n40005   87987\n17329   86995\n17585   89795\n32296   59660\n81836   11644\n89435   65322\n55149   59423\n56971   50141\n26342   95142\n57894   56227\n49762   33007\n48949   65641\n40453   53505\n67613   23537\n27110   87987\n25231   63910\n92546   50713\n70074   27554\n39649   93653\n93231   30520\n60008   79179\n18449   47209\n68828   36207\n18908   72254\n55426   44661\n62522   87987\n60923   25255\n85721   68107\n35153   71814\n20053   24813\n24233   22904\n36237   92731\n92077   68189\n30105   50674\n37032   90255\n12745   54116\n41563   53324\n24700   29145\n60226   85335\n50713   64775\n29972   51790\n79176   19794\n40017   96101\n90724   41345\n51608   39176\n46178   50141\n26151   23489\n19569   44529\n34368   86052\n18948   50801\n62091   17329\n89749   38984\n68315   37514\n52396   19794\n14981   14475\n36038   69571\n50048   50980\n60796   41563\n69942   72877\n80976   25234\n56722   90255\n49489   28090\n60768   65557\n70753   85065\n15233   23522\n94697   87600\n40958   41532\n91709   40116\n83586   19028\n88140   24977\n56993   50980\n17980   53324\n12421   97982\n30183   40884\n50452   53324\n91314   90651\n69995   19028\n16588   28090\n22432   98658\n86088   77868\n46361   65322\n97178   75705\n37444   79320\n12275   96101\n47016   16942\n36822   87327\n62082   31274\n68265   64314\n87344   24603\n40642   23559\n87254   38755\n62372   50713\n89026   68830\n88519   96101\n53514   31808\n24686   41563\n23817   68705\n26704   89031\n37908   65322\n22665   35601\n75378   59200\n16797   86995\n55847   68189\n55932   72688\n41470   96101\n43557   17329\n45439   77868\n41230   76226\n25104   92869\n43736   93653\n85938   93653\n74153   54726\n73956   70350\n70419   37102\n81275   64160\n30656   32684\n46218   32617\n67969   31808\n61544   81806\n39376   56568\n14769   60336\n10199   97703\n61064   40091\n75531   30486\n17211   31808\n75184   74633\n24565   61765\n83922   44529\n11644   25255\n71836   14393\n53030   19028\n83437   33190\n33687   54998\n92054   82083\n48250   68533\n10977   34363\n51050   19028\n80898   68276\n26442   68830\n39875   65514\n24976   76417\n31946   23537\n95278   90255\n71678   26450\n49641   28580\n12962   13674\n13598   30362\n40620   21256\n49062   92869\n88449   79529\n80153   94081\n36918   70556\n77902   99228\n41848   99097\n26032   39378\n23830   50980\n49712   78294\n95464   65322\n76971   27393\n67074   22132\n17629   71246\n92019   92869\n20780   96521\n68372   16880\n49710   88060\n94680   52634\n28626   57101\n31808   60809\n25578   28090\n12020   25255\n46008   33046\n27712   36207\n17168   53033\n92923   87987\n94668   65843\n59490   48858\n69085   38485\n28242   14664\n18302   96101\n64047   71241\n62752   73532\n28873   59278\n22206   18029\n57298   85374\n26420   78294\n74055   30817\n74377   45566\n81846   17058\n35184   27305\n72054   89795\n78666   41563\n80545   96101\n69240   51322\n76319   36831\n23617   14475\n53848   93653\n65082   36888\n18802   93491\n63942   23559\n80208   22876\n17018   68830\n78018   51611\n35520   75130\n43479   88543\n18522   96101\n41260   15010\n58041   21675\n96272   68830\n73601   78294\n44788   52104\n67152   89795\n57671   61399\n33841   56764\n41963   53394\n41010   28090\n53937   65322\n75472   76675\n22253   92068\n24277   93653\n62012   14475\n27539   50141\n29180   41637\n27151   35922\n28752   23559\n31602   47673\n80298   50906\n94689   38297\n87987   48139\n51692   61967\n93653   86995\n99694   96638\n50948   11644\n87830   19794\n57579   93403\n60947   72082\n18514   53324\n99194   25255\n57630   93653\n49914   10526\n34613   94340\n32145   16105\n39569   62764\n14118   31274\n38901   19016\n47443   66925\n83812   31274\n61920   50141\n88684   50713\n32305   31808\n58695   50713\n20016   42720\n68955   31976\n96299   99509\n83258   96101\n49424   68830\n97130   14043\n34668   50936\n27567   35509\n57890   65959\n58399   78860\n88934   50980\n70656   66788\n91507   44529\n53671   87987\n75858   71137\n14726   13674\n25416   31274\n90521   50075\n37289   96101\n79415   19028\n21158   25355\n53210   16168\n35192   81526\n67240   23559\n42967   65310\n81598   93094\n12765   36207\n23853   41643\n78439   22984\n13052   50141\n56642   93653\n19028   82791\n89371   36244\n89795   50799\n41542   90489\n49486   72630\n26630   50763\n35019   68830\n62271   78294\n16433   77868\n42466   57338\n63666   39984\n56231   83564\n51132   96101\n33675   74200\n94670   70445\n51236   17822\n52493   64460\n45346   86995\n41620   31274\n80479   88912\n46200   90255\n13789   60686\n98564   76843\n44974   92717\n76047   80674\n60650   89430\n55723   45722\n89426   97853\n33961   98414\n32872   68189\n65322   12029\n29922   36159\n74923   34697\n37065   59688\n66622   23559\n68253   14475\n28664   53324\n62981   25761\n83161   50674\n22849   50980\n11119   76308\n22980   13794\n76171   19411\n96351   28221\n45573   90255\n19850   79146\n97828   90483\n23867   85271\n36353   50141\n46579   87987\n73434   23559\n57169   68189\n68768   41682\n59354   97617\n62181   64641\n34167   53324\n28374   24803\n55863   57352\n25058   33040\n76126   53005\n97283   51641\n25887   29253\n43067   50713\n51616   61868\n97533   16129\n50692   80951\n43173   41626\n93917   76055\n84713   53465\n24130   13599\n56773   50980\n15310   44529\n63375   50141\n75875   93653\n22284   33135\n46294   77836\n29713   14393\n95318   83346\n83264   61967\n39267   47771\n61101   86995\n47882   96101\n24345   70347\n50674   14475\n17296   12880\n52605   11644\n40817   78294\n36207   93653\n16045   96101\n91784   68830\n34583   69934\n71867   28090\n74898   22671\n54609   27206\n33070   26257\n18570   57394\n16766   87036\n62825   21503\n39793   17504\n12038   82452\n37265   12706\n69479   44529\n96101   44260\n49175   50713\n70708   55412\n50136   14475\n27300   96101\n75794   62368\n10277   87990\n30825   87987\n35563   24149\n12505   91890\n11323   14393\n89922   84455\n10927   65359\n50656   71304\n47973   11644\n17156   92869\n98964   96101\n50980   59345\n94733   23559\n22743   26134\n90255   54273\n80006   65322\n10157   92869\n70496   28090\n25569   41226\n79982   92869\n34897   76485\n83357   86388\n26352   79503\n67432   15174\n49155   72153\n36311   86995\n14394   65333\n70928   51667\n67367   23559\n48195   57003\n52001   26154\n63251   21651\n21894   89795\n50774   43252\n85637   36207\n79243   11644\n49512   57954\n22454   15919\n84214   20805\n67121   86995\n49247   78035\n79313   34840\n33168   19814\n48657   92888\n59824   74905\n30088   68830\n74246   90052\n78389   65322\n88418   28090\n93716   62226\n74962   29324\n47309   50980\n93517   14393\n23895   68175\n34548   25255\n32628   84730\n55988   31274\n82578   40953\n51728   16926\n19440   27805\n42922   45159\n52930   41563\n91562   31274\n23559   62680\n92150   26879\n78315   61783\n43601   91325\n87621   17838\n78580   65350\n94778   77868\n68519   83273\n35509   66389\n82288   52439\n65083   19794\n86995   13010\n66618   95850\n18656   70145\n98537   65322\n60842   52161\n68830   10132\n99689   24077\n33740   89795\n45595   53090\n78239   36207\n20185   36207\n87307   69366\n83009   77868\n34685   88642\n13674   28090\n82450   69909\n44812   75146\n54296   92869\n73558   94990\n21422   48229\n49473   10547\n66108   68189\n71169   74202\n78276   40690\n82977   78294\n61842   15634\n31582   95459\n39064   14475\n70204   18593\n71244   87987\n31642   50490\n98413   37109\n61175   50141\n37168   23559\n44093   11032\n18806   40848\n91249   73483\n95812   32572\n93644   68189\n30669   20850\n75404   92869\n53324   50141\n80675   50216\n14897   73401\n34074   29952\n16366   32630\n95656   28090\n73964   58896\n90705   66916\n92869   59662\n99522   78294\n35903   19794\n33033   42610\n55650   50980\n29289   11753\n32302   58345\n76036   57644\n74870   31274\n85035   77868\n79322   25255\n50332   31274\n78294   44529\n93000   53324\n36560   19028\n40041   53525\n70360   89795\n19074   98749\n32829   89603\n61436   71046\n89938   85369\n52708   28090\n83958   53324\n88155   67097\n32730   75527\n64221   23559\n60391   97432\n70047   20185\n12372   73527\n46501   29274\n66552   14746\n56373   51614\n95596   11782\n81196   72623\n32282   60515\n49504   14393\n57642   34348\n95402   87987\n81625   68830\n28527   37199\n71475   31808\n94280   23005\n55623   99355\n46783   29073\n36641   81559\n74788   14535\n87994   78773\n80189   77868\n33263   89795\n23537   23537\n25755   22264\n67413   72800\n74924   73774\n81215   78294\n78206   92869\n36161   50141\n54925   86995\n66305   49951\n42462   28090\n99051   88912\n44954   89795\n88856   28090\n63026   85778\n22651   24813\n39262   14475\n86176   69982\n65395   14393\n12926   78294\n81994   53324\n16933   30191\n46987   19794\n37215   28090\n15340   63748\n40271   86674\n23747   52856\n61156   11644\n65356   56048\n72336   51278\n21864   77868\n99351   13349\n24599   79046\n62281   23361\n81871   53324\n14029   42297\n50141   48720\n46677   43636\n10745   35965\n39344   80864\n38077   50038\n13983   89795\n66663   67877\n64175   19028\n62355   68830\n96823   79443\n46436   44754\n53388   68830\n45987   92723\n87646   11707\n75997   45545\n69968   93653\n30425   44529\n83211   88109\n28725   64932\n47043   89795\n34475   31274\n42302   94895\n66558   92753\n48964   50713\n19546   78294\n51026   89795\n89346   57408\n52993   54676\n29577   38385\n85932   60320\n18030   22556\n65993   19922\n74692   23559\n61588   89795\n50688   69541\n93760   44529\n75094   96101\n68976   86835\n46278   50980\n97836   44529\n17576   32708\n48519   46071\n72647   93653\n54724   34155\n45186   43448\n44529   41828\n90404   86357\n63175   44529\n88381   25963\n32140   23537\n43348   36423\n41733   88912\n84065   98953\n20389   96101\n38749   93788\n37929   35143\n63747   35340\n72249   93653\n98042   59381\n22741   95783\n88124   33425\n16493   44529\n36599   69408\n50436   41563\n67695   86149\n89091   20022\n60708   92607\n28750   68830\n80224   39113\n34580   96101\n79688   34798\n14870   68189\n47719   29252\n57652   33458\n65541   87987\n86435   19794\n95204   81239\n43800   50980\n94063   11644\n24096   36588\n36628   95478\n81443   17329\n61221   57166\n52782   78294\n16740   31274\n68369   45653\n28895   44529\n39222   65582\n97201   77602\n81119   11644\n41083   50141\n72917   25255\n46148   21269\n44495   18020\n99464   90525\n67254   58381\n52750   28135\n63899   55754\n14617   50713\n36962   50713\n41322   73436\n22504   38709\n72577   39875\n67799   68830\n68284   71156\n46011   61967\n50367   31808\n45832   87987\n88775   87987\n32562   26340\n43756   49887\n73444   16547\n67302   92449\n22133   85451\n17768   77868\n69281   39885\n87364   25255\n41209   27363\n37792   77868\n66667   73746\n22195   28090\n65037   37556\n28634   89795\n23901   50674\n40511   95801\n47779   45253\n76489   86807\n77873   66992\n87523   35509\n32876   50980\n62342   50980\n84222   41563\n88205   40382\n78856   20051\n97888   68189\n22233   17329\n35868   81437\n80155   93653\n82730   78294\n12733   19794\n55038   26258\n50682   23250\n42043   74279\n54719   71512\n54474   23991\n61776   25255\n55564   41563\n39404   31274\n94954   14475\n76258   89795\n87689   67995\n65619   59930\n41846   17435\n21990   22185\n60161   53026\n44955   57523\n84178   39875\n32693   87987\n19125   44529\n96731   93653\n98080   44529\n72947   95746\n67285   23344\n78101   77580\n43064   11644\n81350   23483\n46937   11644\n97686   79381\n66339   60744\n39269   50674\n61837   77868\n97647   86995\n44613   93568\n73127   68830\n64048   80370\n15530   87987\n63926   51860\n95853   91981\n26155   28090\n82222   19794\n10035   87445\n16445   93653\n67972   15558\n51780   68830\n52358   31274\n83942   60096\n64899   11955\n56009   96101\n42288   36590\n53349   65322\n76255   50713\n53044   26351\n37184   31274\n24813   19028\n62309   52490\n93607   19028\n27423   45568\n26128   78294\n72691   50141\n42162   60052\n78247   10613\n80209   31808\n38310   93653\n59228   47607\n24897   23559\n55176   37760\n33062   53324\n26521   39170\n93209   68189\n89881   23559\n11418   50980\n16884   78294\n31995   50980\n17858   98671\n49107   96101\n50512   54526\n56890   65322\n76173   65309\n51569   52845\n73919   23537\n62591   16739\n53735   79935\n14454   69804\n19976   46609\n";
    }
}