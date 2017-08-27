
var camelCaseTokenizer = function (obj) {
    var previous = '';
    return obj.toString().trim().split(/[\s\-]+|(?=[A-Z])/).reduce(function(acc, cur) {
        var current = cur.toLowerCase();
        if(acc.length === 0) {
            previous = current;
            return acc.concat(current);
        }
        previous = previous.concat(current);
        return acc.concat([current, previous]);
    }, []);
}
lunr.tokenizer.registerFunction(camelCaseTokenizer, 'camelCaseTokenizer')
var searchModule = function() {
    var idMap = [];
    function y(e) { 
        idMap.push(e); 
    }
    var idx = lunr(function() {
        this.field('title', { boost: 10 });
        this.field('content');
        this.field('description', { boost: 5 });
        this.field('tags', { boost: 50 });
        this.ref('id');
        this.tokenizer(camelCaseTokenizer);

        this.pipeline.remove(lunr.stopWordFilter);
        this.pipeline.remove(lunr.stemmer);
    });
    function a(e) { 
        idx.add(e); 
    }

    a({
        id:0,
        title:"MarkdownPdfOrientation",
        content:"MarkdownPdfOrientation",
        description:'',
        tags:''
    });

    a({
        id:1,
        title:"IMarkdownPdfRunner",
        content:"IMarkdownPdfRunner",
        description:'',
        tags:''
    });

    a({
        id:2,
        title:"MarkdownPdfRunnerSettings",
        content:"MarkdownPdfRunnerSettings",
        description:'',
        tags:''
    });

    a({
        id:3,
        title:"MarkdownPdfOptions",
        content:"MarkdownPdfOptions",
        description:'',
        tags:''
    });

    a({
        id:4,
        title:"MarkdownPdfRunner",
        content:"MarkdownPdfRunner",
        description:'',
        tags:''
    });

    a({
        id:5,
        title:"MarkdownPdfPaperFormat",
        content:"MarkdownPdfPaperFormat",
        description:'',
        tags:''
    });

    a({
        id:6,
        title:"MarkdownPdfRunnerAliases",
        content:"MarkdownPdfRunnerAliases",
        description:'',
        tags:''
    });

    a({
        id:7,
        title:"MarkdownPdfRunnerSettingsExtensions",
        content:"MarkdownPdfRunnerSettingsExtensions",
        description:'',
        tags:''
    });

    y({
        url:'/Cake.Markdown-Pdf/Cake.Markdown-Pdf/api/Cake.Markdown_Pdf/MarkdownPdfOrientation',
        title:"MarkdownPdfOrientation",
        description:""
    });

    y({
        url:'/Cake.Markdown-Pdf/Cake.Markdown-Pdf/api/Cake.Markdown_Pdf/IMarkdownPdfRunner',
        title:"IMarkdownPdfRunner",
        description:""
    });

    y({
        url:'/Cake.Markdown-Pdf/Cake.Markdown-Pdf/api/Cake.Markdown_Pdf/MarkdownPdfRunnerSettings',
        title:"MarkdownPdfRunnerSettings",
        description:""
    });

    y({
        url:'/Cake.Markdown-Pdf/Cake.Markdown-Pdf/api/Cake.Markdown_Pdf/MarkdownPdfOptions',
        title:"MarkdownPdfOptions",
        description:""
    });

    y({
        url:'/Cake.Markdown-Pdf/Cake.Markdown-Pdf/api/Cake.Markdown_Pdf/MarkdownPdfRunner',
        title:"MarkdownPdfRunner",
        description:""
    });

    y({
        url:'/Cake.Markdown-Pdf/Cake.Markdown-Pdf/api/Cake.Markdown_Pdf/MarkdownPdfPaperFormat',
        title:"MarkdownPdfPaperFormat",
        description:""
    });

    y({
        url:'/Cake.Markdown-Pdf/Cake.Markdown-Pdf/api/Cake.Markdown_Pdf/MarkdownPdfRunnerAliases',
        title:"MarkdownPdfRunnerAliases",
        description:""
    });

    y({
        url:'/Cake.Markdown-Pdf/Cake.Markdown-Pdf/api/Cake.Markdown_Pdf/MarkdownPdfRunnerSettingsExtensions',
        title:"MarkdownPdfRunnerSettingsExtensions",
        description:""
    });

    return {
        search: function(q) {
            return idx.search(q).map(function(i) {
                return idMap[i.ref];
            });
        }
    };
}();
