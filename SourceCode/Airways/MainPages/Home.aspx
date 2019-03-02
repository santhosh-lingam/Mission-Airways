<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Airways.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <style>
        .mySlides {
            display: none;
        }

        /* Slideshow container */
        .slideshow-container {
            max-width: 700px;
            position: relative;
            margin: auto;
        }



        /* Next & previous buttons */
        .prev, .next {
            cursor: pointer;
            position: absolute;
            top: 50%;
            width: auto;
            padding: 16px;
            margin-top: -22px;
            color: white;
            font-weight: bold;
            font-size: 18px;
            transition: 0.6s ease;
            border-radius: 0 3px 3px 0;
        }

        /* Position the "next button" to the right */
        .next {
            right: 0;
            border-radius: 3px 0 0 3px;
        }

            /* On hover, add a black background color with a little bit see-through */
            .prev:hover, .next:hover {
                background-color: rgba(0,0,0,0.8);
            }

        /* Caption text */
        .text {
            color: #f2f2f2;
            font-size: 15px;
            padding: 8px 12px;
            position: absolute;
            bottom: 8px;
            width: 100%;
            text-align: center;
        }

        /* Number text (1/3 etc) */
        .numbertext {
            color: #f2f2f2;
            font-size: 12px;
            padding: 8px 12px;
            position: absolute;
            top: 0;
        }

        /* The dots/bullets/indicators */
        .dot {
            cursor: pointer;
            height: 13px;
            width: 13px;
            margin: 0 2px;
            background-color: #bbb;
            border-radius: 50%;
            display: inline-block;
            transition: background-color 0.6s ease;
        }

            .active, .dot:hover {
                background-color: #717171;
            }

        /* Fading animation */
        .fade {
            -webkit-animation-name: fade;
            -webkit-animation-duration: 1.5s;
            animation-name: fade;
            animation-duration: 1.5s;
        }

        @-webkit-keyframes fade {
            from {
                opacity: .4;
            }

            to {
                opacity: 1;
            }
        }

        @keyframes fade {
            from {
                opacity: .4;
            }

            to {
                opacity: 1;
            }
        }

        /* On smaller screens, decrease text size */
        @media only screen and (max-width: 300px) {
            .prev, .next, .text {
                font-size: 11px;
            }
        }
    </style>


    <div class="slideshow-container">
        <div class="mySlides fade">
            <img src="../SlideShow/SlideShow%20(1).jpg" width="800" height="400" />

        </div>

        <div class="mySlides fade">
            <img src="../SlideShow/SlideShow%20(1).PNG" width="800" height="400" />


        </div>
        <div class="mySlides fade">
            <img src="../SlideShow/SlideShow%20(2).jpg" width="800" height="400" />


        </div>

        <div class="mySlides fade">
            <img src="../SlideShow/SlideShow%20(3).jpg" width="800" height="400" />


        </div>

        <div class="mySlides fade">
            <img src="../SlideShow/SlideShow%20(4).jpg" width="800" height="400" />


        </div>
        <div class="mySlides fade">
            <img src="../SlideShow/SlideShow%20(5).jpg" width="800" height="400" />


        </div>


        <div class="mySlides fade">
            <img src="../SlideShow/SlideShow%20(6).jpg" width="800" height="400" />

            <
        </div>
        <div class="mySlides fade">
            <img src="../SlideShow/SlideShow%20(7).jpg" width="800" height="400" />


        </div>
        <asp:Label ID="Exception_Label" runat="server" Font-Bold="True" Font-Size="Large" Text=""></asp:Label>
    </div>
    <div class="mySlides fade">
        <img src="../SlideShow/SlideShow%20(8).jpg" width="800" height="400" />


    </div>





    <div style="text-align: center">
        <span class="dot" onclick="currentSlide(1)"></span>
        <span class="dot" onclick="currentSlide(2)"></span>
        <span class="dot" onclick="currentSlide(3)"></span>
        <span class="dot" onclick="currentSlide(4)"></span>
        <span class="dot" onclick="currentSlide(5)"></span>
        <span class="dot" onclick="currentSlide(6)"></span>
        <span class="dot" onclick="currentSlide(7)"></span>
        <span class="dot" onclick="currentSlide(8)"></span>
        <span class="dot" onclick="currentSlide(9)"></span>
    </div>

    

    <script>
        var slideIndex = 0;
        showSlides();

        function showSlides() {
            var i;
            var slides = document.getElementsByClassName("mySlides");
            var dots = document.getElementsByClassName("dot");
            for (i = 0; i < slides.length; i++) {
                slides[i].style.display = "none";
            }
            slideIndex++;
            if (slideIndex > slides.length) { slideIndex = 1 }
            for (i = 0; i < dots.length; i++) {
                dots[i].className = dots[i].className.replace(" active", "");
            }
            slides[slideIndex - 1].style.display = "block";
            dots[slideIndex - 1].className += " active";
            setTimeout(showSlides, 2000); // Change image every 2 seconds
        }
    </script>






</asp:Content>
