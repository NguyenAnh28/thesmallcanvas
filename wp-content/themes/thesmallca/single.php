<?php
/**
* The template for displaying all single posts
*
* @link https://developer.wordpress.org/themes/basics/template-hierarchy/#single-post
*
* @package thesmallca
*/

get_header();
?>

<main>
    <section class="box-blog-single">
        <div class="container">
            <div class="content-single">
                <div class="title-single">
                    <h1><?php the_title(); ?></h1>
                </div>
                <div class="text-single">
                    <?php the_content(); ?>
                </div>
            </div>
            <div class="title text-center">
                <h2>RELATED ARTICLES</h2>
            </div>
            <div class="list-article">
                <div class="row">
                    <?php
                    $tax = array(
                        'post_type'     => 'post',
                        'orderby'       => 'ID', 
                        'posts_per_page' => 3,
                        'post__not_in'   => array(get_the_ID())
                    );
                    $looptax = new WP_Query( $tax ); 

                    while ( $looptax->have_posts() ) : $looptax->the_post();
                    ?>
                        <div class="col-md-4">
                            <div class="item-article">
                                <div class="avarta"><a href="<?php the_permalink(); ?>"><img src="<?= the_post_thumbnail_url(); ?>" class="img-fluid w-100" alt="<?php the_title(); ?>"></a></div>
                                <div class="info">
                                    <div class="date"><?= get_the_date('d/m/Y'); ?></div>
                                    <h3><a href="<?php the_permalink(); ?>"><?php the_title(); ?></a></h3>
                                    <div class="desc">
                                        <?php the_excerpt(); ?>
                                    </div>
                                </div>
                            </div>
                        </div>
                    <?php
                        endwhile;
                        wp_reset_query(); 
                    ?>  
                </div>
            </div>
        </div>
    </section>
</main>

<?php
get_footer();
