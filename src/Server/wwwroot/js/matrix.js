
// let run_matrix = () => {
//     console.log("loaded");
//     // var canvas = document.body.appendChild(document.createElement('canvas')),
//     //     context = canvas.getContext('2d');
//     var canvas = document.getElementById("code").appendChild(document.createElement('canvas')), context = canvas.getContext('2d');
//     canvas.classList.add("matrix");

//     context.globalCompositeOperation = 'lighter';
//     canvas.width = window.innerWidth;
//     canvas.height = window.innerHeight;

//     var stripCount = 60, stripX = new Array(), stripY = new Array(), dY = new Array(), stripFontSize = new Array();

//     var textStrip = [
//         'a', 
//         'b', 
//         'c', 
//         'd', 
//         'e', 
//         'f', 
//         'g', 
//         'h', 
//         'i', 
//         'j', 
//         'k', 
//         'l', 
//         'm', 
//         'n', 
//         'o', 
//         'p', 
//         'q',
//         'r',
//         's',
//         't',
//         'u',
//         'v',
//         'w',
//         'x',
//         'y',
//         'z'
//     ];

//     draw();

//     for (var i = 0; i < stripCount; i++) {
//         stripX[i] = Math.floor(Math.random() * 1265);
//         stripY[i] = -100;
//         dY[i] = Math.floor(Math.random() * 7) + 3;
//         stripFontSize[i] = Math.floor(Math.random() * 16) + 8;
//     }

//     var theColors = ['#cefbe4', '#81ec72', '#5cd646', '#54d13c', '#4ccc32', '#43c728'];

//     var elem, context, timer;

//     function drawStrip(x, y) {
//         for (var k = 0; k <= 20; k++) {
//             var randChar = textStrip[Math.floor(Math.random() * textStrip.length)];
//             if (context.fillText) {
//                 switch (k) {
//                     case 0:
//                         context.fillStyle = theColors[0]; break;
//                     case 1:
//                         context.fillStyle = theColors[1]; break;
//                     case 3:
//                         context.fillStyle = theColors[2]; break;
//                     case 7:
//                         context.fillStyle = theColors[3]; break;
//                     case 13:
//                         context.fillStyle = theColors[4]; break;
//                     case 17:
//                         context.fillStyle = theColors[5]; break;
//                 }
//                 context.fillText(randChar, x, y);
//             }
//             y -= stripFontSize[k];
//         }
//     }

//     function draw() {
//         // clear the canvas and set the properties
//         context.clearRect(0, 0, canvas.width, canvas.height);
//         context.shadowOffsetX = context.shadowOffsetY = 0;
//         context.shadowBlur = 8;
//         context.shadowColor = '#94f475';

//         for (var j = 0; j < stripCount; j++) {
//             context.font = stripFontSize[j] + 'px MatrixCode';
//             context.textBaseline = 'top';
//             context.textAlign = 'center';

//             if (stripY[j] > 1358) {
//                 stripX[j] = Math.floor(Math.random() * canvas.width);
//                 stripY[j] = -100;
//                 dY[j] = Math.floor(Math.random() * 7) + 3;
//                 stripFontSize[j] = Math.floor(Math.random() * 16) + 8;
//                 drawStrip(stripX[j], stripY[j]);
//             } else drawStrip(stripX[j], stripY[j]);

//             stripY[j] += dY[j];
//         }
//         setTimeout(draw, 70);
//     }

// };
